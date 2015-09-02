using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfGroup
    /// </summary>
    public class WpfGroup : WpfControl<CUITControls.WpfGroup>
    {
        public WpfGroup(By searchConfiguration = null)
            : this(new CUITControls.WpfGroup(), searchConfiguration)
        {
        }

        public WpfGroup(CUITControls.WpfGroup sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}