using System;
using Music_Garden.Music_Garden.Domain.Abstracts;

namespace Music_Garden.Music_Garden.Domain.Models
{
    public class Infos
    {
        public string country_iso { get; set; }
        public string country { get; set; }
        public bool open { get; set; }
        public Array offers { get; set; }
    }
}