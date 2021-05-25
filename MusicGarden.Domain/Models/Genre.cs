using System;
using webapi.MusicGarden.Domain.Abstracts;

namespace webapi.MusicGarden.Domain.Models
{
    public class Genre : Entity
    {
        public string name { get; set; }
        public string picture { get; set; }
        public string picture_small { get; set; }
        public string picture_medium { get; set; }
        public string picture_big { get; set; }
        public string picture_xl { get; set; }
    }
}