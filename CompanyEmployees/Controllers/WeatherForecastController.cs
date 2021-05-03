using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info mesage from our values controller");
            _logger.LogDebug("Here is debug mesage from our values controller");
            _logger.LogWarn("Here is warn mesage from our values controller");
            _logger.LogError("Here is error mesage from our values controller");

            return new string[] { "value1", "value2" };
        }
    }
}