using NinjectLearning.Logger.Abstract;
using System;

namespace NinjectLearning.Logger.Concrete
{
    public class LoggerManager<TLogger> : ILogger
        where TLogger : ILogger, new()
    {
        private readonly ILogger _logger;
        public LoggerManager()
        {
            _logger = new TLogger();
        }

        public void Log(string message, DateTime logDate)
        {
            _logger.Log(message, logDate);
        }
    }
}
