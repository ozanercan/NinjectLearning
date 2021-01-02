using NinjectLearning.Logger.Abstract;
using System;

namespace NinjectLearning.Logger.Concrete.LoggerTypes
{
    public class TextLogger : ILogger
    {
        public void Log(string message, DateTime logDate)
        {
            Console.WriteLine($"Logged in Text File: { message } \n Log Date: { logDate.ToShortDateString() }");
        }
    }
}
