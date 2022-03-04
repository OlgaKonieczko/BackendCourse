using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Net_Core_Program.Controllers
{
    [ApiController]
    [Route("kurs")]
    public class KursController : ControllerBase
    {

        public KursController()
        {
        }

        [HttpGet]
        [Route("getMessage")]
        public IActionResult getMessage()
        {
           return Ok("Hej, jestem backendowcem");
           
        }

    }
}
