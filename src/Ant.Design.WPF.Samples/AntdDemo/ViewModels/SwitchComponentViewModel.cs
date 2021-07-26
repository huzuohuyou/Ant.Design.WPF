using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace AntdDemo.ViewModels
{
    internal class SwitchComponentViewModel : ViewModelBase
    {
        public SwitchComponentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator ea)
           : base(regionManager, dialogService, ea)
        {
        }


    }
}
