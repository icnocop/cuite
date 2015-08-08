using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfListItem
    /// </summary>
    public class CUITe_WpfListItem : CUITe_WpfControl<WpfListItem>
    {
        public CUITe_WpfListItem() : base() { }
        public CUITe_WpfListItem(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
        }
    }
}