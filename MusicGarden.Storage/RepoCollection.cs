using MusicGarden.Storage.Repositories;

namespace MusicGarden.Storage
{
    public class RepoCollection
    {
        public readonly MusicGardenContext _con;
        public PlaylistRepository Playlists { get; }
        public UserRepository Users { get; }
        public TrackRepository Tracks { get; }
    }
}