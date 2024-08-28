﻿using YoutubeExplode;
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

            var videoMetadata = await _youtube.Videos.GetAsync(videoUrl);
            var outputFilePath = Path.Combine(outputDirectory, $"{SanitizeFileName(videoMetadata.Title)}.mp4");
            // get the audio stream with the one closest to the specified quality or the highest quality
            var audioStreamInfo = await GetAudioStreamAsync(downloadOptions);

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

            var videoMetadata = await _youtube.Videos.GetAsync(videoUrl);
            var outputFilePath = Path.Combine(outputDirectory, $"{SanitizeFileName(videoMetadata.Title)}.mp3");
            var audioStreamInfo = await GetAudioStreamAsync(downloadOptions);

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