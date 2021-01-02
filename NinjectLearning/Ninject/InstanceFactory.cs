using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace NinjectLearning.Ninject
{
    public static class InstanceFactory<T>
    {
        private static IKernel _kernel;

        public static T GetInstance()
        {
            _kernel = new StandardKernel(new InstanceModule());
            return _kernel.Get<T>();
        }
    }
}
