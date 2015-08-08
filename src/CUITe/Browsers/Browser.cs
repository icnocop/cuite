namespace CUITe.Browsers
{
    public class Browser : IBrowser
    {
        public string Name { get; set; }
        public string ProcessName { get; set; }
        public string WindowClassName { get; set; }
        public string DialogClassName { get; set; }

        public Browser(string name, string windowClassName)
            : this(name, name, windowClassName)
        {

        }

        public Browser(string name, string processName, string windowClassName, string dialogClassName = null)
        {
            this.Name = name;
            this.ProcessName = processName;
            this.WindowClassName = windowClassName;
            this.DialogClassName = dialogClassName;
        }
    }
}
