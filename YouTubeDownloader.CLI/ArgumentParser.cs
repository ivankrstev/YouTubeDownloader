using CommandLine;
using YouTubeDownloader.Core;
using static YouTubeDownloader.Core.DownloadOptions;

namespace YouTubeDownloader.CLI
{
    internal static class ArgumentParser
    {
        private static readonly Dictionary<string, HashSet<string>> validValues = new()
        {
            { "video-quality", new HashSet<string> { "highest-available", "2160p", "1440p", "1080p", "720p", "480p", "360p", "240p", "144p" } },
            { "audio-quality", new HashSet<string> { "highest-available", "lowest" } },
            { "format", new HashSet<string> { "mp4", "webm", "mp3" } }
        };

        private static bool ValidateValue(string optionName, string value)
        {
            return validValues[optionName].Contains(value);
        }

        public static DownloadOptions? ParseArguments(string[] args)
        {
            DownloadOptions? downloadOptions = null;
            var parser = new Parser(config => config.HelpWriter = Console.Out);
            if (args.Length == 0)
            {
                parser.ParseArguments<Options>(["--help"]);
                Environment.Exit(1);
            }
            parser.ParseArguments<Options>(args)
                .WithParsed(opts =>
                {
                    if (!ValidateValue("video-quality", opts.VideoQuality))
                    {
                        Console.WriteLine($"Error: Invalid value '{opts.VideoQuality}' for video quality.");
                        Environment.Exit(1);
                    }
                    if (!ValidateValue("audio-quality", opts.AudioQuality))
                    {
                        Console.WriteLine($"Error: Invalid value '{opts.AudioQuality}' for audio quality.");
                        Environment.Exit(1);
                    }
                    if (!ValidateValue("format", opts.Format))
                    {
                        Console.WriteLine($"Error: Invalid value '{opts.Format}' for format.");
                        Environment.Exit(1);
                    }
                    if (!Directory.Exists(opts.OutputDirectory))
                    {
                        Console.WriteLine($"Error: Output directory '{opts.OutputDirectory}' does not exist.");
                        Environment.Exit(1);
                    }
                    var (isPlaylist, normalizedUrl) = ProcessYouTubeInput(opts.VideoUrl);
                    downloadOptions = new DownloadOptions
                    {
                        Url = normalizedUrl,
                        VideoQuality = opts.VideoQuality,
                        AudioQuality = opts.AudioQuality,
                        Format = opts.Format,
                        OutputDirectory = opts.OutputDirectory,
                        IsPlaylist = isPlaylist
                    };
                })
                .WithNotParsed(_ =>
                {
                    Console.WriteLine("Error parsing arguments.");
                    Environment.Exit(1);
                });
            return downloadOptions;
        }
    }

    internal class Options
    {
        [Value(0, MetaName = "video-url", Required = true, HelpText = "The URL of the video to download.")]
        public required string VideoUrl { get; set; }

        [Option('o', "output-directory", Default = ".", HelpText = "Set the output directory.")]
        public required string OutputDirectory { get; set; } = ".";

        [Option('v', "video-quality", Default = "highest-available", HelpText = "Set the video quality.")]
        public string VideoQuality { get; set; } = "highest-available";

        [Option('a', "audio-quality", Default = "highest-available", HelpText = "Set the audio quality.")]
        public string AudioQuality { get; set; } = "highest-available";

        [Option('f', "format", Default = "mp4", HelpText = "Set the output format.")]
        public string Format { get; set; } = "mp4";
    }
}