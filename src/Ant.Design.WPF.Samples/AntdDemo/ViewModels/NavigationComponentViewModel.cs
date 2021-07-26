using AntdDemo.EventAggregators;
using MicrosoftToDO.Common;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;
using System.Collections.ObjectModel;

namespace AntdDemo.ViewModels
{
    public class NavigationComponentViewModel : ViewModelBase
    {

        #region 字段属性
        private ObservableCollection<MenuItem> menuItems;

        public ObservableCollection<MenuItem> MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }
        #endregion

        #region 构造函数
        public NavigationComponentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator ea)
          : base(regionManager, dialogService, ea)
        {
            MenuItems = new ObservableCollection<MenuItem>();
            MenuItems.Add(new MenuItem() {  Name = "组件总览",  });
            MenuItems.Add(new MenuItem() {  Name = "通用",  IsEnabled=false});
            MenuItems.Add(new MenuItem() {  Name = "Button按钮",  Code = "ButtonComponent" });
            MenuItems.Add(new MenuItem() {  Name = "Icon图标",  Code= "IconComponent" });
            MenuItems.Add(new MenuItem() {  Name = "Typography排版",  });
            MenuItems.Add(new MenuItem() {  Name = "布局",  IsEnabled = false });
            MenuItems.Add(new MenuItem() {  Name = "Divider分割线",  });
            MenuItems.Add(new MenuItem() {  Name = "Grid栅格",  });
            MenuItems.Add(new MenuItem() {  Name = "Layout布局",  });
            MenuItems.Add(new MenuItem() {  Name = "Space间距",  });
            MenuItems.Add(new MenuItem() {  Name = "导航",  IsEnabled = false });
            MenuItems.Add(new MenuItem() {  Name = "Affix固钉",  });
            MenuItems.Add(new MenuItem() {  Name = "Breadcrumb面包屑",  });
            MenuItems.Add(new MenuItem() {  Name = "Dropdown下拉菜单",  });
            MenuItems.Add(new MenuItem() {  Name = "Menu导航菜单",  });
            MenuItems.Add(new MenuItem() {  Name = "PageHeader页头",  });
            MenuItems.Add(new MenuItem() {  Name = "Pagination分页",  });
            MenuItems.Add(new MenuItem() {  Name = "Steps步骤条",  });
            MenuItems.Add(new MenuItem() {  Name = "数据录入",  IsEnabled = false });
            MenuItems.Add(new MenuItem() {  Name = "AutoComplete自动完成",  });
            MenuItems.Add(new MenuItem() {  Name = "Cascader级联选择",  });
            MenuItems.Add(new MenuItem() {  Name = "Checkbox多选框",  Code= "CheckBoxComponent" });
            MenuItems.Add(new MenuItem() {  Name = "DatePicker日期选择框",  });
            MenuItems.Add(new MenuItem() {  Name = "Form表单",  });
            MenuItems.Add(new MenuItem() {  Name = "Input输入框", Code="InputComponent" });
            MenuItems.Add(new MenuItem() {  Name = "InputNumber数字输入框",  });
            MenuItems.Add(new MenuItem() {  Name = "Mentions提及",  });
            MenuItems.Add(new MenuItem() {  Name = "Radio单选框", Code= "RadioButtonComponent" });
            MenuItems.Add(new MenuItem() {  Name = "Rate评分",  });
            MenuItems.Add(new MenuItem() {  Name = "Select选择器", Code= "SelectComponent" });
            MenuItems.Add(new MenuItem() {  Name = "Slider滑动输入条",  });
            MenuItems.Add(new MenuItem() {  Name = "Switch开关", Code= "SwitchComponent" });
            MenuItems.Add(new MenuItem() {  Name = "TimePicker时间选择框",  });
            MenuItems.Add(new MenuItem() {  Name = "Transfer穿梭框",  });
            MenuItems.Add(new MenuItem() {  Name = "TreeSelect树选择",  });
            MenuItems.Add(new MenuItem() {  Name = "Upload上传",  });
            MenuItems.Add(new MenuItem() {  Name = "数据展示",  IsEnabled = false });
            MenuItems.Add(new MenuItem() {  Name = "Avatar头像",  Code= "AvatarComponent" });
            MenuItems.Add(new MenuItem() {  Name = "Badge徽标数",  });
            MenuItems.Add(new MenuItem() {  Name = "Calendar日历",  });
            MenuItems.Add(new MenuItem() {  Name = "Card卡片",  });
            MenuItems.Add(new MenuItem() {  Name = "Carousel走马灯",  });
            MenuItems.Add(new MenuItem() {  Name = "Collapse折叠面板",  });
            MenuItems.Add(new MenuItem() {  Name = "Comment评论",  });
            MenuItems.Add(new MenuItem() {  Name = "Descriptions描述列表",  });
            MenuItems.Add(new MenuItem() {  Name = "Empty空状态",  });
            MenuItems.Add(new MenuItem() {  Name = "Image图片",  });
            MenuItems.Add(new MenuItem() {  Name = "List列表",  });

            MenuItems.Add(new MenuItem() {  Name = "Popover气泡卡片",  });
            MenuItems.Add(new MenuItem() {  Name = "Statistic统计数值",  });
            MenuItems.Add(new MenuItem() {  Name = "Table表格",  });
            MenuItems.Add(new MenuItem() {  Name = "Tabs标签页",  });
            MenuItems.Add(new MenuItem() {  Name = "Tag标签", Code= "TagComponent" });
            MenuItems.Add(new MenuItem() {  Name = "Timeline时间轴",  });
            MenuItems.Add(new MenuItem() {  Name = "Tooltip文字提示",  Code= "ToolTipComponent" });
            MenuItems.Add(new MenuItem() {  Name = "Tree树形控件",  });
            MenuItems.Add(new MenuItem() {  Name = "反馈",  IsEnabled = false });
            MenuItems.Add(new MenuItem() {  Name = "Alert警告提示",  Code = "AlertComponent" });
            MenuItems.Add(new MenuItem() {  Name = "Drawer抽屉",  });
            MenuItems.Add(new MenuItem() {  Name = "Message全局提示",  });
            MenuItems.Add(new MenuItem() {  Name = "Modal对话框",  });
            MenuItems.Add(new MenuItem() {  Name = "Notification通知提醒框",  });
            MenuItems.Add(new MenuItem() {  Name = "Popconfirm气泡确认框",  });
            MenuItems.Add(new MenuItem() {  Name = "Progress进度条",  });
            MenuItems.Add(new MenuItem() {  Name = "Result结果",  });
            MenuItems.Add(new MenuItem() {  Name = "Skeleton骨架屏",  });
            MenuItems.Add(new MenuItem() {  Name = "Spin加载中", Code= "SpinComponent" });
            MenuItems.Add(new MenuItem() {  Name = "其他",  IsEnabled = false });
            MenuItems.Add(new MenuItem() {  Name = "Anchor锚点",  });
            MenuItems.Add(new MenuItem() {  Name = "BackTop回到顶部",  });
            MenuItems.Add(new MenuItem() {  Name = "ConfigProvider全局化配置",  });

        }

        
        #endregion

        #region 命令

        public DelegateCommand<object[]> SelectedCommand => new((a) =>
        {
            var menuItem = a[0] as MenuItem;
            Publish(menuItem);
        });

        private void Publish(MenuItem menuItem) {
            EventAggregator.GetEvent<SwitchViewEventAggregator>().Publish(menuItem); 
        }
        #endregion

        #region 方法函数

        #endregion






    }
}
