using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinListItem
    /// </summary>
    public class WinListItem : WinControl<CUITControls.WinListItem>
    {
        public WinListItem(string searchProperties = null)
            : this(new CUITControls.WinListItem(), searchProperties)
        {
        }

        public WinListItem(CUITControls.WinListItem sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        public bool Selected
        {
            get { return SourceControl.Selected; }
        }
    }
}