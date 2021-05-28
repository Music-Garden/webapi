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
    private readonly RepoCollection _repoCollection;
    public MusicController(IConfiguration configuration, RepoCollection repoCollection)
    {
      _configuration = configuration;
      _repoCollection = repoCollection;
    }

    [HttpGet]
    public async Task<Album> IndexAsync()
    {
      var response = client.GetAsync($"{_configuration["Services:webapi"]}/album/302127").GetAwaiter().GetResult();

      if (response.IsSuccessStatusCode)
      {
        //var Album = JsonConvert.DeserializeObject<Album>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        var Album = JsonConvert.DeserializeObject<Album>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        return Album;
      }

      return null;

    }

    [HttpGet]
    public async Task<List<string>> SearchAsync(String name)
    {
      var response = client.GetAsync($"{_configuration["Services:webapi"]}/search?q=track:{name}").GetAwaiter().GetResult();

      List<string> songlink = new List<string>();
      object info = new object();

      if (response.IsSuccessStatusCode)
      {

        //Search search = await response.Content.ReadFromJsonAsync<Search>();
        RootSearch search = JsonConvert.DeserializeObject<RootSearch>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        foreach (var item in search.data)
        {
          songlink.Add(item.link);
        }

        return songlink;
      }

      return null;

    }
    [HttpGet]
    public async Task<string> SavePlaylistAsync(string playlistname, string track)
    {
      var playlists = _repoCollection.playlistRepo.Select(a => a.playlistname == playlistname).FirstOrDefault();
      if (playlists != null)
      {
        playlists.Tracks.Add(new SavingTrack() { trackname = track });
        _repoCollection.playlistRepo.Update<SavingPlaylist>(_repoCollection.con.Playlists, playlists);
      }
      else
      {
        SavingPlaylist tempplaylists = new SavingPlaylist();
        tempplaylists.Tracks.Add(new SavingTrack() { trackname = track });
        tempplaylists.playlistname = playlistname;
        _repoCollection.playlistRepo.Insert<SavingPlaylist>(_repoCollection.con.Playlists, tempplaylists);
      }
      _repoCollection.Save();

      return "success";

    }
    public async Task<List<string>> ReadPlaylistAsync(String pname)
    {
      var playlists = _repoCollection.playlistRepo.Select(a => a.playlistname == pname).FirstOrDefault();
      List<string> returnlist = new List<string>();
      foreach (var item in playlists.Tracks)
      {
        returnlist.Add(item.trackname);
      }
      return returnlist;
    }



  }
}
