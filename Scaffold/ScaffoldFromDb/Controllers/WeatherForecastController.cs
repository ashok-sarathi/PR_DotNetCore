using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScaffoldFromDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("[action]")]
        public void Get()
        {

        }

        [HttpGet("[action]/{id}")]
        public void Get1(int id)
        {

        }

        [HttpGet("[action]")]
        public void Get2(int id, string name)
        {

        }

        [HttpGet("[action]")]
        public void Get3([FromQuery] Dom dom)
        {

        }

        [HttpPost("[action]")]
        public void Create([FromBody] Dom dom)
        {

        }

        [HttpPut("[action]/id")]
        public void Update(int id, [FromBody] Dom dom)
        {

        }

        [HttpDelete("[action]/id")]
        public void Delete(int id)
        {

        }
    }

    public class Dom
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
