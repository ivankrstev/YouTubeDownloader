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
            // Get playlist and videos metadata
            var (playlistMetadata, videosMetadata) = await GetPlaylistMetadataAndVideos(playlistUrl);
            Console.WriteLine($"Playlist: {playlistMetadata.Title}");
            Console.WriteLine(videosMetadata.Count + " videos found.");
            // Download video by video
            foreach (var video in videosMetadata)
            {
                _downloadOptions.Url = video.Url;
                await _videoDownloader.DownloadVideoAsync(_downloadOptions);
            }
            Console.WriteLine("Playlist download complete.");
        }

        // write me a function to get playlist metadata togeher with the metadata of videos in the playlist(title, duration) in one function:
        public async Task<(YoutubeExplode.Playlists.Playlist, IReadOnlyList<YoutubeExplode.Playlists.PlaylistVideo>)> GetPlaylistMetadataAndVideos(string playlistUrl)
        {
            var playlist = await _youtube.Playlists.GetAsync(playlistUrl);
            var videos = await _youtube.Playlists.GetVideosAsync(playlistUrl);
            return (playlist, videos);
        }
    }
}