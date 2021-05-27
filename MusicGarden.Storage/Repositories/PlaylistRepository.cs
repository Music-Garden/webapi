using System;
using System.Collections.Generic;
using MusicGarden.Domain.Interfaces;
using webapi.MusicGarden.Domain.Models;

namespace MusicGarden.Storage.Repositories
{
    public class PlaylistRepository : IRepository<Playlist>
    {
        public bool Destroy(Playlist entry)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Playlist entry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Playlist> Select(Func<Playlist, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Playlist Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}