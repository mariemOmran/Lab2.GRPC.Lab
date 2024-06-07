using Microsoft.AspNetCore.Mvc;

namespace lab.Grpc.Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] winter = new[]
        {
            "Freez",  "Cool", "Warm","Hot"
        };

        private readonly ILogger<WeatherForecastController> ilogger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            ilogger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TempC = Random.Shared.Next(-20, 55),
                Winter = winter[Random.Shared.Next(winter.Length)]
            })
            .ToArray();
        }
    }
}
