using AntdDemo.Views;
using DramaEnglish.Infrastructure.Register;
using DryIoc;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace AntdDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {

            return Container.Resolve<HelloAntdComponent>();
        }

        public App()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            PrismRegister.ExecureRegister(containerRegistry, assemblyName);
            //RegisterViewWithRegion(containerRegistry);
        }

       
    }
}
