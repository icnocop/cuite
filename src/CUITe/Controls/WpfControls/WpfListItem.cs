using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfListItem
    /// </summary>
    public class WpfListItem : WpfControl<CUITControls.WpfListItem>
    {
        public WpfListItem(string searchProperties = null)
            : this(new CUITControls.WpfListItem(), searchProperties)
        {
        }

        public WpfListItem(CUITControls.WpfListItem sourceControl, string searchProperties = null)
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