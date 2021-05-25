using System.Collections.Generic;
using Music_Garden.Music_Garden.Domain.Abstracts;

namespace Music_Garden.Music_Garden.Domain.Models
{
    public class Search : Entity
    {
        public bool readable { get; set; }
        public string title { get; set; }
        public string title_short { get; set; }
        public string title_version { get; set; }
        public string link { get; set; }
        public int duration { get; set; }
        public int rank { get; set; }
        public bool explicit_lyrics { get; set; }
        public string preview { get; set; }
        public Artist artist { get; set; }
        public Album album { get; set; }
        public bool strict { get; set; }
        public List<object> order { get; set; }
    }
}