using System;
using System.Collections.Generic;
using Music_Garden.Music_Garden.Domain.Abstracts;

namespace Music_Garden.Music_Garden.Domain.Models
{
    public class Chart : Entity
    {
        public List<Track> tracks { get; set; }
        public List<Album> albums { get; set; }
        public List<Artist> artists { get; set; }
        public List<Playlist> playlists { get; set; }
        public List<Podcast> podcasts { get; set; }
    }
}
