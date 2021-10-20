using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Dashboard.Controllers
{
    [ApiController]
    public class TdxApiController : ControllerBase
    {
       static  Guid beid_key = Guid.Parse("2E3A96D2-3282-490C-A2D3-DFD2C7D5A573");
       static Guid Wkey = Guid.Parse("A872AE3A-0D74-43D6-87AF-12FD569C6530");
        [HttpGet]
        [Route("https://cityofsalem.teamdynamix.com/TDWebApi/api/auth/loginadmin")]
      public IActionResult Get()
        {
            return Ok("Reading all users");
        }
        [HttpGet]
        [Route("api/tickets/{uid}")]
        public IActionResult GetByUid(int uid)
        {
            return Ok($"Reading user #{uid}");
        }

    }
}
