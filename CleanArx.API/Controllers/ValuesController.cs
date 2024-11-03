using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArx.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
         [HttpGet]
        public IActionResult GetWeather()
        {
           /* var forecast = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 25,
                Summary = "Sunny"
            };
*/
            var forecast = new WeatherForecast(DateTime.Now, 25, "Sunny");
            return Ok(forecast);
        }
    }

    public record WeatherForecast(DateTime Date, int TemperatureC, string Summary);
 }
