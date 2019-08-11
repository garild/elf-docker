using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace ServiceLog.Controllers
{
    [Route("api/[controller]/[action]")]
    public class LogController
    {
        private readonly ILogger _logger;

        public LogController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<LogController>();
        }

        [HttpGet]
        public void Error()
        {
            for(int i = 0; i < 1000; i++)
            {
                _logger.LogError($"This is ERRRORRRRRRRRRRR {DateTime.Today}");
            }
        }

        [HttpGet]
        public void Info()
        {
            for (int i = 0; i < 1000; i++)
            {
                _logger.LogInformation($"This is info {DateTime.Today}");
            }
            
        }
    }
}
