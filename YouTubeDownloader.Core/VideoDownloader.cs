using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
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

        public async Task<(bool success, string message)> DownloadVideoAsync(DownloadOptions downloadOptions, Action<string>? logAction = null)
        {
            var format = downloadOptions.Format;

            var (data, errorMessage) = await TryGetVideoMetadata(downloadOptions);
            if (errorMessage != null)
            {
                logAction?.Invoke(errorMessage);
                return (false, errorMessage);
            }
            var videoMetadata = data!;

            if (format == "mp3")
            {
                var audioStreamInfoMp3 = await GetAudioStreamAsync(downloadOptions);
                if (audioStreamInfoMp3 == null)
                {
                    logAction?.Invoke($"No suitable audio stream found for: {videoMetadata.Title}");
                    return (false, $"No suitable audio stream found for: {videoMetadata.Title}");
                }
                logAction?.Invoke($"- Title: {videoMetadata.Title}");
                logAction?.Invoke($"  Length: {videoMetadata.Duration} | Size: {FormatSize(audioStreamInfoMp3.Size.Bytes)}");
                logAction?.Invoke($"  Bitrate: {audioStreamInfoMp3.Bitrate}");
                var streamInfo = new IStreamInfo[] { audioStreamInfoMp3 };
                var (downloadedSuccessfullyMp3, responseMessageMp3) = await TryDownloadVideoOrAudioAsync(downloadOptions, streamInfo, videoMetadata);
                if (!downloadedSuccessfullyMp3)
                {
                    logAction?.Invoke(responseMessageMp3);
                    return (false, responseMessageMp3);
                }
                logAction?.Invoke("Downloaded!");
                logAction?.Invoke("");
                return (true, videoMetadata.Title);
            }

            // get the audio stream with the one closest to the specified quality or the highest quality
            var audioStreamInfo = await GetAudioStreamAsync(downloadOptions);
            // get the video stream with the one closest to the specified quality or the highest quality
            var videoStreamInfo = await GetVideoStreamAsync(downloadOptions);

            if (videoStreamInfo == null || audioStreamInfo == null)
            {
                logAction?.Invoke($"No suitable stream found for: {videoMetadata.Title}");
                return (false, $"No suitable stream found for: {videoMetadata.Title}");
            }
            logAction?.Invoke($"- Title: {videoMetadata.Title}");
            logAction?.Invoke($"  Length: {videoMetadata.Duration} | Size: {FormatSize(audioStreamInfo.Size.Bytes + videoStreamInfo.Size.Bytes)}");
            logAction?.Invoke($"  Quality: {videoStreamInfo.VideoQuality.Label} | {audioStreamInfo.Bitrate}");
            var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };
            var (downloadedSuccessfully, responseMessage) = await TryDownloadVideoOrAudioAsync(downloadOptions, streamInfos, videoMetadata);
            if (!downloadedSuccessfully)
            {
                logAction?.Invoke(responseMessage);
                return (false, responseMessage);
            }
            logAction?.Invoke("Downloaded!");
            logAction?.Invoke("");
            return (true, videoMetadata.Title);
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

        public async Task<IStreamInfo?> GetAudioStreamAsync(DownloadOptions downloadOptions)
        {
            var streamManifest = await _youtube.Videos.Streams.GetManifestAsync(downloadOptions.Url);
            var audioStreams = streamManifest.GetAudioOnlyStreams()
                                             .OrderBy(s => s.Bitrate)
                                             .ToList();
            return downloadOptions.AudioQuality switch
            {
                "lowest" => audioStreams[0],
                "medium" => audioStreams[audioStreams.Count / 2],
                "highest-available" => audioStreams[^1],
                _ => null,
            };
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

        public async Task<(Video? data, string? errorMessage)> TryGetVideoMetadata(DownloadOptions downloadOptions)
        {
            try
            {
                return (await _youtube.Videos.GetAsync(downloadOptions.Url), null);
            }
            catch (HttpRequestException)
            {
                return (null, "Network error: Failed to get video metadata");
            }
            catch (Exception)
            {
                return (null, "Failed to get video metadata");
            }
        }

        public async Task<(bool downloadedSuccessfully, string responseMessage)> TryDownloadVideoOrAudioAsync(DownloadOptions downloadOptions, IStreamInfo[] streamInfos, Video videoMetadata)
        {
            var outputDirectory = downloadOptions.OutputDirectory;
            var format = downloadOptions.Format;
            string? videoTitle = null;
            try
            {
                videoTitle = videoMetadata.Title;
                var outputFilePath = Path.Combine(outputDirectory, $"{SanitizeFileName(videoTitle)}.{format}");
                await _youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder(outputFilePath).Build());
                return (true, videoTitle);
            }
            catch (HttpRequestException)
            {
                return (false, $"Network error: Failed to download the video {videoTitle ?? string.Empty}");
            }
            catch (Exception)
            {
                return (false, $"Failed to download the video {videoTitle ?? string.Empty}");
            }
        }
    }
}