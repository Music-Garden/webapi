using System;
using Music_Garden.Music_Garden.Domain.Abstracts;

namespace Music_Garden.Music_Garden.Domain.Models
{
    public class Editorial : Entity
    {
        public string name { get; set; }
        public string picture { get; set; }
        public string picture_small { get; set; }
        public string picture_medium { get; set; }
        public string picture_big { get; set; }
        public string picture_xl { get; set; }
    }
}