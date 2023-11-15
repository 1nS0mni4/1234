using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {
        private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Bal" +
            "my", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public TodoItem Get() {
            return new TodoItem() { OK = true };
        }

        [HttpPost]
        public TodoItem Post(TodoItem item) {
            return item;
        }
    }
}