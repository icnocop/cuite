using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfMenuItem
    /// </summary>
    public class WpfMenuItem : WpfControl<CUITControls.WpfMenuItem>
    {
        public WpfMenuItem(CUITControls.WpfMenuItem sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfMenuItem(), searchProperties)
        {
        }

        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        public bool Expanded
        {
            get { return SourceControl.Expanded; }
            set { SourceControl.Expanded = value; }
        }

        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }

        public bool IsTopLevelMenu
        {
            get { return SourceControl.IsTopLevelMenu; }
        }
    }
}