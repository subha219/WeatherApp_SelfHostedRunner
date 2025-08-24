using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatetimeController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public DatetimeController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetDatetime")]
        public string GetDateTime()
        {
            return DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss");
        }

    }
}
