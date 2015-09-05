using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfListItem
    /// </summary>
    public class WpfListItem : WpfControl<CUITControls.WpfListItem>
    {
        public WpfListItem(By searchConfiguration = null)
            : this(new CUITControls.WpfListItem(), searchConfiguration)
        {
        }

        public WpfListItem(CUITControls.WpfListItem sourceControl, By searchConfiguration = null)
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