namespace YouTubeDownloader.Core
{
    public class DownloadOptions
    {
        public required string Url { get; set; }
        public required string VideoQuality { get; set; }
        public required string AudioQuality { get; set; }
        public required string Format { get; set; }
        public required string OutputDirectory { get; set; }
        public required bool IsPlaylist { get; set; }
    }
}