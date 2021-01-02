using Ninject.Modules;
using NinjectLearning.Logger.Abstract;
using NinjectLearning.Logger.Concrete;
using NinjectLearning.Logger.Concrete.LoggerTypes;

namespace NinjectLearning.Ninject
{
    public class InstanceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<LoggerManager<TextLogger>>();
        }
    }
}
