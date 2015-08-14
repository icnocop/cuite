using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfListItem
    /// </summary>
    public class WpfListItem : WpfControl<CUITControls.WpfListItem>
    {
        public WpfListItem() { }
        public WpfListItem(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return UnWrap().DisplayText; }
        }

        public bool Selected
        {
            get { return UnWrap().Selected; }
        }
    }
}