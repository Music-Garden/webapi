using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MusicGarden.Domain.Models;

namespace MusicGarden.Storage.Repositories
{
  public class ReadPlaylistRepository : Repository
  {
    private readonly MusicGardenContext _context;
    public ReadPlaylistRepository(MusicGardenContext context)
    {
      _context = context;
    }
    public IEnumerable<SavingPlaylist> Select(Func<SavingPlaylist, bool> filter)
    {
      return _context.Playlists
      .Include(a => a.Tracks)
      .Where(filter);
    }
  }
}