using System;
using System.Collections.Generic;
using System.Text;

namespace NinjectLearning.Logger.Abstract
{
    public interface ILogger
    {
        void Log(string message, DateTime logDate);
    }
}
