using CommandLine;

namespace YouTubeDownloader.CLI
{
    internal static class ArgumentParser
    {
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