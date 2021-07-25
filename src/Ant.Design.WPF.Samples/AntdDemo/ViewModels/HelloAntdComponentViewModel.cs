using AntdDemo.Views;
using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace AntdDemo.ViewModels
{
    public class HelloAntdComponentViewModel : ViewModelBase
    {
        public HelloAntdComponentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator ea)
           : base(regionManager, dialogService, ea)
        {
            //regionManager.RegisterViewWithRegion("NavigatorComponent", typeof(NavigatorComponent));
        }
    }
}
