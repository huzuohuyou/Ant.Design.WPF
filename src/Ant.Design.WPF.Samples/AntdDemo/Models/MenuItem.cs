namespace MicrosoftToDO.Common
{
    public class MenuItem
    {
        public string Icon { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string BackColor { get; set; } = "#1890ff";
        public bool IsEnabled { get; set; } = true;
        public string Visibility
        {
            get
            {
                if (IsEnabled)
                    return "Visibility";
                else
                    return "Collapsed";
            }
        }

        public string UnVisibility
        {
            get
            {
                if (!IsEnabled)
                    return "Visibility";
                else
                    return "Collapsed";
            }
        }
    }
}
