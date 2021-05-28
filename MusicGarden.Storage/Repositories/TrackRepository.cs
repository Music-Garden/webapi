using System;
using System.Collections.Generic;
using System.Linq;
using MusicGarden.Domain.Interfaces;
using MusicGarden.Domain.Models;

namespace MusicGarden.Storage
{
    public class TrackRepository : IRepository<Track>
    {
        private MusicGardenContext _con;
        public TrackRepository(MusicGardenContext con)
        {
            _con = con;
        }
        public bool Destroy(Track entry)
        {
            _con.Tracks.Remove(entry);
            return true;
        }

        public bool Insert(Track entry)
        {
            _con.Tracks.Add(entry);
            return true;
        }

        public IEnumerable<Track> Select(Func<Track, bool> filter)
        {
            return _con.Tracks.Where(filter);
        }

        public Track Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}