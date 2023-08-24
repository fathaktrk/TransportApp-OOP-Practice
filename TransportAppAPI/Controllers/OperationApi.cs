using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TransportAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationApi : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DistanceCities.CityNames);
        }
    }
}
