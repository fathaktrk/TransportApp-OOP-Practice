using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TransportAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("GetCityNames")]
        public IActionResult GetCityNames()
        {
            return Ok(DistanceCities.CityNames);
        }

        
        [HttpGet("GetDistanceCities")]
        public IActionResult GetDistanceCities()
        {
            var kmList = JsonConvert.SerializeObject(DistanceCities.KmList);
 
            return Ok(kmList);
        }
    }
}
