
namespace MusicGarden.Domain.Models
{
  public class DataSearch
  {
    public string id { get; set; }
    public bool readable { get; set; }
    public string title { get; set; }
    public string title_short { get; set; }
    public string title_version { get; set; }
    public string link { get; set; }
    public string duration { get; set; }
    public object rank { get; set; }
    public bool explicit_lyrics { get; set; }
    public int explicit_content_lyrics { get; set; }
    public int explicit_content_cover { get; set; }
    public string preview { get; set; }
    public string md5_image { get; set; }
    public Artist artist { get; set; }
    public Album album { get; set; }
    public string type { get; set; }
  }
}