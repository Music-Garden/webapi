using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Medialab.Client.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MusicController : ControllerBase
  {



    [HttpGet]
    public List<string> Get()
    {

      return new List<string>{

                "R&B",
                "Rap"

            };

    }
  }
}
