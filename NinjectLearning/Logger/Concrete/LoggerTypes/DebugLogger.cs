using NinjectLearning.Logger.Abstract;
using System;

namespace NinjectLearning.Logger.Concrete.LoggerTypes
{
    public class DebugLogger : ILogger
    {
        public void Log(string message, DateTime logDate)
        {
            Console.WriteLine($"Logged in Debug: { message } \n Log Date: { logDate.ToShortDateString() }");
        }
    }
}
