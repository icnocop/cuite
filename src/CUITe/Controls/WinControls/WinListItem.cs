using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinListItem
    /// </summary>
    public class WinListItem : WinControl<CUITControls.WinListItem>
    {
        public WinListItem() : base() { }
        public WinListItem(string searchParameters) : base(searchParameters) { }

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