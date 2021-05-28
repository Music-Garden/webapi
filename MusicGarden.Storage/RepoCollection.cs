using MusicGarden.Storage.Repositories;

namespace MusicGarden.Storage
{
    public class RepoCollection
    {
        public readonly MusicGardenContext _con;
        public PlaylistRepository Playlists { get; }
        public UserRepository Users { get; }
        public TrackRepository Tracks { get; }
        public RepoCollection(MusicGardenContext con)
        {
            _con = con;
            Playlists = new PlaylistRepository(_con);
            Users = new UserRepository(_con);
            Tracks = new TrackRepository(_con);
        }
        public void Save()
        {
            _con.SaveChanges();
        }
    }
}