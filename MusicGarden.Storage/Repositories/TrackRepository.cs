using System;
using System.Collections.Generic;
using MusicGarden.Domain.Interfaces;
using MusicGarden.Domain.Models;

namespace MusicGarden.Storage
{
  public class TrackRepository : IRepository<Track>
  {
    public bool Destroy(Track entry)
    {
      throw new NotImplementedException();
    }

    public bool Insert(Track entry)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Track> Select(Func<Track, bool> filter)
    {
      throw new NotImplementedException();
    }

    public Track Upgrade()
    {
      throw new NotImplementedException();
    }
  }
}