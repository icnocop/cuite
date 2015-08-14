using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfExpander
    /// </summary>
    public class WpfExpander : WpfControl<CUITControls.WpfExpander>
    {
        public WpfExpander()
        {
        }

        public WpfExpander(string searchParameters)
            : base(searchParameters)
        {
        }

        public bool Expanded
        {
            get { return UnWrap().Expanded; }
        }

        public string Header
        {
            get { return UnWrap().Header; }
        }
    }
}