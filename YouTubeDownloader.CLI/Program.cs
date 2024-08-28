using YouTubeDownloader.Core;

namespace YouTubeDownloader.CLI
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            var downloadOptions = ArgumentParser.ParseArguments(args);
            if (downloadOptions == null)
            {
                Console.WriteLine("Invalid arguments provided.");
                Environment.Exit(1);
            }
            else if (downloadOptions.IsPlaylist)
            {
                await new PlaylistDownloader(downloadOptions).DownloadPlaylistAsync(downloadOptions.Url);
            }
            else
            {
                await new VideoDownloader().DownloadVideoAsync(downloadOptions, Console.WriteLine);
            }
        }
    }
}