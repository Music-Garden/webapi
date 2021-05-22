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


namespace Medialab.Client.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MusicController : ControllerBase
  {
    private static readonly HttpClient client = new HttpClient();
    private IConfiguration _configuration;
    public MusicController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    [HttpGet]
    public object Index()
    {
      var response = client.GetAsync($"{_configuration["Services:webapi"]}").GetAwaiter().GetResult();



      if (response.IsSuccessStatusCode)
      {
        var result = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());

        return result;
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
