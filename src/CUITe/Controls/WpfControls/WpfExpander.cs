using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfExpander
    /// </summary>
    public class WpfExpander : WpfControl<CUITControls.WpfExpander>
    {
        public WpfExpander(CUITControls.WpfExpander sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfExpander(), searchProperties)
        {
        }

        public bool Expanded
        {
            get { return SourceControl.Expanded; }
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}