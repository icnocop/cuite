using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfExpander
    /// </summary>
    public class WpfExpander : WpfControl<CUIT.WpfExpander>
    {
        public WpfExpander() : base() { }
        public WpfExpander(string searchParameters) : base(searchParameters) { }

        public bool Expanded
        {
            get { return this.UnWrap().Expanded; }
        }

        public string Header
        {
            get { return this.UnWrap().Header; }
        }
    }
}