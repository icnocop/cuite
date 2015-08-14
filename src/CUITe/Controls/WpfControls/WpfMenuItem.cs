using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfMenuItem
    /// </summary>
    public class WpfMenuItem : WpfControl<CUITControls.WpfMenuItem>
    {
        public WpfMenuItem() : base() { }
        public WpfMenuItem(string searchParameters) : base(searchParameters) { }

        public bool Checked
        {
            get { return UnWrap().Checked; }
            set { UnWrap().Checked = value; }
        }

        public bool Expanded
        {
            get { return UnWrap().Expanded; }
            set { UnWrap().Expanded = value; }
        }

        public bool HasChildNodes
        {
            get { return UnWrap().HasChildNodes; }
        }

        public string Header
        {
            get { return UnWrap().Header; }
        }

        public bool IsTopLevelMenu
        {
            get { return UnWrap().IsTopLevelMenu; }
        }
    }
}