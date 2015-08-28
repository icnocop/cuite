using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfGroup
    /// </summary>
    public class WpfGroup : WpfControl<CUITControls.WpfGroup>
    {
        public WpfGroup(CUITControls.WpfGroup sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfGroup(), searchProperties)
        {
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}