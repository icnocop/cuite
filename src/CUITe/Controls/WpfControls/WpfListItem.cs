using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfListItem
    /// </summary>
    public class WpfListItem : WpfControl<CUITControls.WpfListItem>
    {
        public WpfListItem(CUITControls.WpfListItem sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfListItem(), searchProperties)
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