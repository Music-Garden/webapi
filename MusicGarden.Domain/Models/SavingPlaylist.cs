using System.Collections.Generic;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class SavingPlaylist : Entity
  {
    public string playlistname { get; set; }
    public List<SavingTrack> Tracks { get; set; } = new List<SavingTrack>();
  }
}