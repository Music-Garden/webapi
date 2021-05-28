using System;
using System.Collections.Generic;
using System.Linq;
using MusicGarden.Domain.Interfaces;
using MusicGarden.Domain.Models;

namespace MusicGarden.Storage.Repositories
{
    public class PlaylistRepository : IRepository<Playlist>
    {
        private MusicGardenContext _con;

        public PlaylistRepository(MusicGardenContext con)
        {
            _con = con;
        }

        public bool Destroy(Playlist entry)
        {
            _con.Playlists.Remove(entry);
            return true;
        }

        public bool Insert(Playlist entry)
        {
            _con.Playlists.Add(entry);
            return true;
        }

        public IEnumerable<Playlist> Select(Func<Playlist, bool> filter)
        {
            return _con.Playlists.Where(filter);
        }

        public Playlist Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}