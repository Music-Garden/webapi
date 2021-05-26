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
using webapi.MusicGarden.Domain.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MusicGarden.Client.Controllers
{
  [ApiController]
  [Route("[Controller]/[Action]")]
  public class MusicController : ControllerBase
  {
    private static readonly HttpClient client = new HttpClient();
    private IConfiguration _configuration;
    public MusicController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    [HttpGet]
    public async Task<Album> IndexAsync()
    {
      var response = client.GetAsync($"{_configuration["Services:webapi"]}/album/302127").GetAwaiter().GetResult();

      object info = new object();

      if (response.IsSuccessStatusCode)
      {
        //var Album = JsonConvert.DeserializeObject<Album>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        var Album = await response.Content.ReadFromJsonAsync<Album>();
        return Album;
      }

      return null;

    }

    [HttpGet]
    public async Task<Search> SearchAsync(String name)
    {
      name = "i need a dollar";
      var response = client.GetAsync("https://api.deezer.com/search?q=track:i%20need%20a%20dollar:").GetAwaiter().GetResult();

      object info = new object();

      if (response.IsSuccessStatusCode)
      {

        //Search search = await response.Content.ReadFromJsonAsync<Search>();
        Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);


        return search;
      }

      return null;

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
