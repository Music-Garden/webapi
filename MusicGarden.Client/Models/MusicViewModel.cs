using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MusicGarden.Domain.Models;
using MusicGarden.Storage;

namespace MusicGarden.Client.Models
{
    public class MusicViewModel : IValidatableObject
    {
        public List<Playlist> Playlists { get; set; }
        public List<Track> Tracks { get; set; }
        public List<User> Users { get; set; }
        public string PlaylistEntry { get; set; }
        public string TrackEntry { get; set; }
        public string UserEntry { get; set; }

        public void Saver(RepoCollection _repo)
        {
            //Playlists = _repo.Playlists;
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }
}