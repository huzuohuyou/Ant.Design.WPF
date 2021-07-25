using DramaEnglish.Infrastructure.Register;
using DryIoc;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
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

            return Container.Resolve<MainWindow>();
        }
        public App()
        {
        }
        public App(IRegionManager regionManager)
        {
            //regionManager.RegisterViewWithRegion("LoginRegion", typeof(LoginComponent));
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            PrismRegister.RegisterTypes(containerRegistry);
        }
    }
}
