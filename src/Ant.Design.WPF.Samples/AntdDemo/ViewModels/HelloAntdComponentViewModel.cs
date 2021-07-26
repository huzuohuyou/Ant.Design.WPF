using AntdDemo.EventAggregators;
using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;
using MenuItem = MicrosoftToDO.Common.MenuItem;
namespace AntdDemo.ViewModels
{
    public class HelloAntdComponentViewModel : ViewModelBase
    {
        public HelloAntdComponentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator ea)
           : base(regionManager, dialogService, ea)
        {
            EventAggregator.GetEvent<SwitchViewEventAggregator>().Subscribe(Subscribe);
        }

        private void Subscribe(MenuItem menuItem)
        {
            if (menuItem.Code == null)
                return;

            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            Assembly serviceAss = Assembly.Load(assemblyName);
            Type[] serviceTypes = serviceAss.GetTypes();
            var type = serviceTypes.ToList().FirstOrDefault(r => r.Name.EndsWith(menuItem.Code));
            if (type != null)
            {
                RegionManager.RegisterViewWithRegion("ControlDetailComponent", type);
                var view = RegionManager.Regions["ControlDetailComponent"].Views.FirstOrDefault(r=>(r as UserControl).ToString().EndsWith(type.Name));
                RegionManager.Regions["ControlDetailComponent"].Activate(view);
            }
        }
    }
}
