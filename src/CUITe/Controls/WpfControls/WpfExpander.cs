using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfExpander
    /// </summary>
    public class WpfExpander : WpfControl<CUITControls.WpfExpander>
    {
        public WpfExpander(By searchConfiguration = null)
            : this(new CUITControls.WpfExpander(), searchConfiguration)
        {
        }

        public WpfExpander(CUITControls.WpfExpander sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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