using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Json;
using MusicGarden.Domain.Models;
using MusicGarden.Storage;

namespace MusicGarden.Client.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class MusicController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        private IConfiguration _configuration;
        private readonly RepoCollection _repo;
        public MusicController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<Album> IndexAsync()
        {
            var response = client.GetAsync($"{_configuration["Services:webapi"]}/album/302127").GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
                var Album = JsonConvert.DeserializeObject<Album>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                return Album;
            }

            return null;

        }

        [HttpGet]
        public async Task<string> SearchAsync(String name)
        {
            name = "i need a dollar";
            var response = client.GetAsync($"{_configuration["Services:webapi"]}/search?q=track:{name}").GetAwaiter().GetResult();

            string songlink;
            object info = new object();

            if (response.IsSuccessStatusCode)
            {

                //Search search = await response.Content.ReadFromJsonAsync<Search>();
                RootSearch search = JsonConvert.DeserializeObject<RootSearch>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                songlink = search.data[0].link;

                return songlink;
            }

            return null;

        }

        [HttpPost]
        public string DataBaseTrackSave(string entry)
        {
            if (entry != null)
            {
                var poster = _repo.Tracks.Select(t => t.title == entry);
                if (poster == null)
                {
                    Track newTrack = new Track();
                    newTrack.title = entry;
                    _repo.Tracks.Insert(newTrack);
                    return entry + " has been added to the Database";
                }
                else
                {
                    return "This Already Exists";
                }
            }
            return "Please type something";
        }

        [HttpPost]
        public string DataBasePlaylistSave(string entry)
        {
            if (entry != null)
            {
                var poster = _repo.Playlists.Select(p => p.title == entry);
                if (poster == null)
                {
                    Playlist newPlaylist = new Playlist();
                    newPlaylist.title = entry;
                    _repo.Playlists.Insert(newPlaylist);
                    return entry + " has been added to the Database";
                }
                else
                {
                    return "This Already Exists";
                }
            }
            return "Please type something";
        }

        [HttpPost]
        public string DataBaseUserSave(string entry)
        {
            if (entry != null)
            {
                var poster = _repo.Users.Select(u => u.name == entry);
                if (poster == null)
                {
                    User newUser = new User();
                    newUser.name = entry;
                    _repo.Users.Insert(newUser);
                    return entry + " has been added to the Database";
                }
                else
                {
                    return "This Already Exists";
                }
            }
            return "Please type something";
        }

        [HttpGet]
        public object DataBaseTrackPull(string entry)
        {
            if (entry != null)
            {
                var poster = _repo.Tracks.Select(t => t.title == entry);
                if (poster == null)
                {
                    return "This Does Not Exist";
                }
                else
                {
                    return poster;
                }
            }
            return "Please type something";
        }
        [HttpGet]
        public object DataBasePlaylistPull(string entry)
        {
            if (entry != null)
            {
                var poster = _repo.Tracks.Select(t => t.title == entry);
                if (poster == null)
                {
                    return "This Does Not Exist";
                }
                else
                {
                    return poster;
                }
            }
            return "Please type something";
        }

        [HttpGet]
        public object DataBaseUserPull(string entry)
        {
            if (entry != null)
            {
                var poster = _repo.Users.Select(t => t.name == entry);
                if (poster == null)
                {
                    return "This Does Not Exist";
                }
                else
                {
                    return poster;
                }
            }
            return "Please type something";
        }


        // [HttpGet]
        // public List<string> Get()
        // {

        //   return new List<string>{

        //             "R&B",
        //             "Rap"

        //         };

        //}
    }
}
