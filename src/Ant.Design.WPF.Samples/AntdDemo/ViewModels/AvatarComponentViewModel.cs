using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace AntdDemo.ViewModels
{
    internal class AvatarComponentViewModel : ViewModelBase
    {
        public AvatarComponentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator ea)
           : base(regionManager, dialogService, ea)
        {
        }
    }
}
