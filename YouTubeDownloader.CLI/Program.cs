namespace YouTubeDownloader.CLI
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var downloadOptions = ArgumentParser.ParseArguments(args);
            if (downloadOptions == null)
            {
                Console.WriteLine("Invalid arguments provided.");
                Environment.Exit(1);
            }
        }
    }
}