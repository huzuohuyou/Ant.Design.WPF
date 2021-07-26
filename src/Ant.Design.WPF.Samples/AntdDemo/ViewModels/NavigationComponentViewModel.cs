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
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "组件总览", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "通用", Count = 2 ,IsEnabled=false});
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Button按钮", Count = 2 ,Code = "ButtonComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Icon图标", Count = 2 ,Code= "IconComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Typography排版", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "布局", Count = 2, IsEnabled = false });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Divider分割线", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Grid栅格", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Layout布局", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Space间距", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "导航", Count = 2, IsEnabled = false });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Affix固钉", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Breadcrumb面包屑", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Dropdown下拉菜单", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Menu导航菜单", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "PageHeader页头", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Pagination分页", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Steps步骤条", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "数据录入", Count = 2, IsEnabled = false });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "AutoComplete自动完成", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Cascader级联选择", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Checkbox多选框", Count = 2 ,Code= "CheckBoxComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "DatePicker日期选择框", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Form表单", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Input输入框", Count = 2,Code="InputComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "InputNumber数字输入框", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Mentions提及", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Radio单选框", Count = 2,Code= "RadioButtonComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Rate评分", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Select选择器", Count = 2,Code= "SelectComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Slider滑动输入条", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Switch开关", Count = 2,Code= "SwitchComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "TimePicker时间选择框", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Transfer穿梭框", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "TreeSelect树选择", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Upload上传", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "数据展示", Count = 2, IsEnabled = false });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Avatar头像", Count = 2 ,Code= "AvatarComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Badge徽标数", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Calendar日历", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Card卡片", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Carousel走马灯", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Collapse折叠面板", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Comment评论", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Descriptions描述列表", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Empty空状态", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Image图片", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "List列表", Count = 2 });

            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Popover气泡卡片", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Statistic统计数值", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Table表格", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Tabs标签页", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Tag标签", Count = 2,Code= "TagComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Timeline时间轴", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Tooltip文字提示", Count = 2 ,Code= "ToolTipComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Tree树形控件", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "反馈", Count = 2, IsEnabled = false });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Alert警告提示", Count = 2, Code = "AlertComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Drawer抽屉", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Message全局提示", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Modal对话框", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Notification通知提醒框", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Popconfirm气泡确认框", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Progress进度条", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Result结果", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Skeleton骨架屏", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Spin加载中", Count = 2 ,Code= "SpinComponent" });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "其他", Count = 2, IsEnabled = false });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "Anchor锚点", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "BackTop回到顶部", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "", BackColor = "#1890ff", Name = "ConfigProvider全局化配置", Count = 2 });

        }

        
        #endregion

        #region 命令

        public DelegateCommand<object[]> SelectedCommand => new((a) =>
        {
            var s = (a[0] as MenuItem);
            var menuItem = (a[0] as MenuItem);
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
