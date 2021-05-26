using System.Collections.Generic;

namespace MusicGarden.Domain.Models
{

  public class RootSearch
  {
    public List<DataSearch> data { get; set; }
    public int total { get; set; }
  }

}