using MusicGarden.Storage.Repositories;

namespace MusicGarden.Storage
{
  public class RepoCollection
  {
    public readonly MusicGardenContext con;
    public Repository baseRepo { get; }
    public ReadPlaylistRepository playlistRepo { get; }
    public RepoCollection(MusicGardenContext Thecontext)
    {
      con = Thecontext;
      baseRepo = new Repository();
      playlistRepo = new ReadPlaylistRepository(Thecontext);
    }

    public void Save()
    {
      con.SaveChanges();

    }
  }
}