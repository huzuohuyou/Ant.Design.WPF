using Ant.Design.WPF.Demo.NET5;
using DramaEnglish.Infrastructure.Register;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace Ant.Design.WPF.Demo.NET40
{
    /// <summary>
    /// App.xaml 的交互逻辑
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