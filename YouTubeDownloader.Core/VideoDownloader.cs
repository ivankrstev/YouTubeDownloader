using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace YouTubeDownloader.Core
{
    public class VideoDownloader
    {
        private readonly YoutubeClient _youtube;

        public VideoDownloader()
        {
            _youtube = new YoutubeClient();
        }

        public async Task DownloadVideoAsync(DownloadOptions downloadOptions)
        {
            var videoUrl = downloadOptions.Url;
            var outputDirectory = downloadOptions.OutputDirectory;
            var videoQuality = downloadOptions.VideoQuality;
            var audioQuality = downloadOptions.AudioQuality;
            var format = downloadOptions.Format;

            if (format == "mp3")
            {
                await DownloadAudioAsync(downloadOptions);
                return;
            }

            var streamManifest = await _youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var videoMetadata = await _youtube.Videos.GetAsync(videoUrl);
            var outputFilePath = Path.Combine(outputDirectory, $"{SanitizeFileName(videoMetadata.Title)}.mp4");
            // get the audio stream with the highest bitrate
            var audioStreamInfo = streamManifest
                .GetAudioOnlyStreams()
                .GetWithHighestBitrate();

            // get the video stream with the one closest to the specified quality or the highest quality
            var videoStreamInfo = await GetVideoStreamAsync(downloadOptions);

            if (videoStreamInfo != null && audioStreamInfo != null)
            {
                Console.WriteLine($"- Title: {videoMetadata.Title}");
                Console.WriteLine($"  Length: {videoMetadata.Duration} | Size: {FormatSize(audioStreamInfo.Size.Bytes + videoStreamInfo.Size.Bytes)}");
                Console.WriteLine($"  Quality: {videoStreamInfo.VideoQuality.Label} | {audioStreamInfo.Bitrate}");
                var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };
                await _youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder(outputFilePath).Build());
                Console.WriteLine("Downloaded!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"No suitable stream found for: {videoMetadata.Title}");
            }
        }

        private static string SanitizeFileName(string fileName)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }
            return fileName;
        }

        private static string FormatSize(long size)
        {
            string[] sizes = ["B", "KB", "MB", "GB", "TB"];
            int order = 0;
            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }
            return $"{size:0.##} {sizes[order]}";
        }

        private async Task DownloadAudioAsync(DownloadOptions downloadOptions)
        {
            var videoUrl = downloadOptions.Url;
            var outputDirectory = downloadOptions.OutputDirectory;

            var streamManifest = await _youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var videoMetadata = await _youtube.Videos.GetAsync(videoUrl);
            var outputFilePath = Path.Combine(outputDirectory, $"{SanitizeFileName(videoMetadata.Title)}.mp3");
            var audioStreamInfo = streamManifest
                .GetAudioOnlyStreams().GetWithHighestBitrate();

            if (audioStreamInfo != null)
            {
                Console.WriteLine($"- Title: {videoMetadata.Title}");
                Console.WriteLine($"  Length: {videoMetadata.Duration} | Size: {FormatSize(audioStreamInfo.Size.Bytes)}");
                Console.WriteLine($"  Bitrate: {audioStreamInfo.Bitrate}");
                await _youtube.Videos.DownloadAsync([audioStreamInfo], new ConversionRequestBuilder(outputFilePath).Build());
                Console.WriteLine("Downloaded!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"No suitable stream found for: {videoMetadata.Title}");
            }
        }

        public async Task<IVideoStreamInfo?> GetVideoStreamAsync(DownloadOptions downloadOptions)
        {
            var streamManifest = await _youtube.Videos.Streams.GetManifestAsync(downloadOptions.Url);
            if (downloadOptions.VideoQuality == "highest-available")
            {
                return streamManifest.GetVideoOnlyStreams().GetWithHighestVideoQuality();
            }
            var videoStreams = streamManifest
                .GetVideoOnlyStreams()
                .Select(s => new
                {
                    stream = s,
                    IsHd = s.VideoQuality.Label.Contains("HDR")
                })
                .OrderByDescending(s => s.stream.VideoQuality.Label)
                .ThenByDescending(s => s.IsHd)
                .ThenByDescending(s => s.stream.VideoQuality.Framerate)
                .Where(s => !s.stream.VideoCodec.Contains("av01"))
                .ToList();
            return videoStreams.Find(s => s.stream.VideoQuality.MaxHeight <= int.Parse(downloadOptions.VideoQuality.Replace("p", "")))?.stream ?? videoStreams[^1].stream;
        }
    }
}