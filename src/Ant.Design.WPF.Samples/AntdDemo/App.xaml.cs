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
            PrismRegister.RegisterTypes(containerRegistry, assemblyName);
            //RegisterViewWithRegion(containerRegistry);
        }

        private void RegisterViewWithRegion(IContainerRegistry containerRegistry) {
            var conterEx = containerRegistry as IContainerExtension;
            var regionManager = conterEx.Resolve<IRegionManager>();

            Assembly serviceAss = Assembly.Load("AntdDemo");
            Type[] serviceTypes = serviceAss.GetTypes();

            var contents = serviceTypes.ToList().Where(r => r.Name.EndsWith("Component"));
            foreach (var item in contents)
            {
                regionManager.RegisterViewWithRegion(item.Name, item);
            }
        }
    }
}
