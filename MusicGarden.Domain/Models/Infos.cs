using System;
using MusicGarden.Domain.Abstracts;

namespace webapi.MusicGarden.Domain.Models
{
    public class Infos
    {
        public string country_iso { get; set; }
        public string country { get; set; }
        public bool open { get; set; }
        public Array offers { get; set; }
    }
}