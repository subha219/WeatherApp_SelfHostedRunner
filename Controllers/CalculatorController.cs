using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Interface;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ILogger<WeatherForecastController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }

        // GET api/<CalculatorController>/5
        [HttpGet("Add")]
        public int Get(int a, int b)
        {
            return _calculatorService.Add(a, b);
        }

        [HttpGet("Subtract")]
        public int Subtract(int a, int b)
        {
            return _calculatorService.Subtract(a, b);
        }

        [HttpGet("Multiply")]
        public int Multiply(int a, int b)
        {
            return _calculatorService.Multiply(a, b);
        }

        [HttpGet("Divide")]
        public int Divide(int a, int b)
        {
            return _calculatorService.Divide(a, b);
        }

    }
}
