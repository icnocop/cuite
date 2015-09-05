using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinListItem
    /// </summary>
    public class WinListItem : WinControl<CUITControls.WinListItem>
    {
        public WinListItem(By searchConfiguration = null)
            : this(new CUITControls.WinListItem(), searchConfiguration)
        {
        }

        public WinListItem(CUITControls.WinListItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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