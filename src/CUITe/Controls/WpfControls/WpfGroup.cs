using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfGroup
    /// </summary>
    public class WpfGroup : WpfControl<CUITControls.WpfGroup>
    {
        public WpfGroup()
        {
        }

        public WpfGroup(string searchParameters)
            : base(searchParameters)
        {
        }

        public string Header
        {
            get { return UnWrap().Header; }
        }
    }
}