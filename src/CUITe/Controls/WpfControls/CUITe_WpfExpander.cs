using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfExpander
    /// </summary>
    public class CUITe_WpfExpander : CUITe_WpfControl<WpfExpander>
    {
        public CUITe_WpfExpander() : base() { }
        public CUITe_WpfExpander(string searchParameters) : base(searchParameters) { }

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