using YoutubeExplode;
using YoutubeExplode.Common;

namespace YouTubeDownloader.Core
{
    public class PlaylistDownloader(DownloadOptions downloadOptions)
    {
        private readonly YoutubeClient _youtube = new();
        private readonly VideoDownloader _videoDownloader = new();
        private readonly DownloadOptions _downloadOptions = downloadOptions;

        public async Task DownloadPlaylistAsync(string playlistUrl)
        {
            // Get playlist information
            var playlist = await _youtube.Playlists.GetAsync(playlistUrl);
            Console.WriteLine($"Playlist: {playlist.Title}");
            // Get videos in the playlist
            var videos = await _youtube.Playlists.GetVideosAsync(playlistUrl);
            Console.WriteLine(videos.Count + " videos found.");
            // Download video by video
            foreach (var video in videos)
            {
                _downloadOptions.Url = video.Url;
                await _videoDownloader.DownloadVideoAsync(_downloadOptions);
            }
            Console.WriteLine("Playlist download complete.");
        }
    }
}