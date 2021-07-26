using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace AntdDemo.ViewModels
{
    public class RadioButtonComponentViewModel : ViewModelBase
    {
        public RadioButtonComponentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator ea)
           : base(regionManager, dialogService, ea)
        {
        }


    }
}