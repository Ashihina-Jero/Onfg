using Microsoft.AspNetCore.Mvc;
using Online2.Models;

namespace Online2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        private readonly List<WeatherForecast> _weatherForecasts = new List<WeatherForecast>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_weatherForecasts);
        }

        [HttpPost]
        public IActionResult Post(WeatherForecast weatherForecast)
        {
            _weatherForecasts.Add(weatherForecast);
            return CreatedAtAction(nameof(Get), new { id = _weatherForecasts.Count }, weatherForecast);
        }
    }
}