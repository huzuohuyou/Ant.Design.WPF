using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Linq;
using System.Reflection;
using Mitem = MicrosoftToDO.Common.MenuItem;
namespace AntdDemo.ViewModels
{
    public class ShellComponentViewModel : ViewModelBase
    {
        public ShellComponentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator ea)
           : base(regionManager, dialogService, ea)
        {
            EventAggregator.GetEvent<PubSubEvent<Mitem>>().Subscribe((menuItem) => {
                var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
                Assembly serviceAss = Assembly.Load(assemblyName);
                Type[] serviceTypes = serviceAss.GetTypes();
                var type = serviceTypes.ToList().FirstOrDefault(r => r.Name.EndsWith(menuItem.Code));
                if (type!=null)
                    regionManager.RegisterViewWithRegion("ControlDetailComponent", type);
            });
        }
    }
}
