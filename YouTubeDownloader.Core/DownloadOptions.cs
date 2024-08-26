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

        public static (bool isPlaylist, string normalizedUrl) ProcessYouTubeInput(string input)
        {
            if (Uri.TryCreate(input, UriKind.Absolute, out _))
            {
                // assume it's a URL
                if (input.Contains("playlist") || input.Contains("list="))
                    return (true, input);
                return (false, input);
            }
            else if (input.Length == 11)
            {
                // Assume it's a video ID
                return (true, $"https://www.youtube.com/watch?v={input}");
            }
            else if (input.Length == 34 && (input.StartsWith("PL") || input.StartsWith("UU") || input.StartsWith("LL")))
            {
                // Assume it's a playlist ID
                return (true, $"https://www.youtube.com/playlist?list={input}");
            }
            else
            {
                return (false, "");
            }
        }
    }
}