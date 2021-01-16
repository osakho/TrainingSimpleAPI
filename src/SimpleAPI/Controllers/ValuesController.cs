using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public ValuesController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" ,"value2"};
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Sakho Cheikh Oumar";
        }
    }
}
