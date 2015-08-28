using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinListItem
    /// </summary>
    public class WinListItem : WinControl<CUITControls.WinListItem>
    {
        public WinListItem(CUITControls.WinListItem sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinListItem(), searchProperties)
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