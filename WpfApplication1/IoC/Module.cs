using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using WpfApplication1.ViewModels;

namespace WpfApplication1.IoC
{
    class Module : NinjectModule
    {
        public override void Load()
        {
            Bind<MainWindowViewModel>().ToSelf();
        }
    }
}
