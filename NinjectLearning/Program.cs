using NinjectLearning.Logger.Abstract;
using NinjectLearning.Logger.Concrete;
using NinjectLearning.Logger.Concrete.LoggerTypes;
using NinjectLearning.Ninject;
using System;

namespace NinjectLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = InstanceFactory<ILogger>.GetInstance();

            logger.Log("Bu bir log metnidir.", DateTime.Now);
            Console.ReadKey();
        }
    }
}
