using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfGroup
    /// </summary>
    public class WpfGroup : WpfControl<CUITControls.WpfGroup>
    {
        public WpfGroup(string searchProperties = null)
            : this(new CUITControls.WpfGroup(), searchProperties)
        {
        }

        public WpfGroup(CUITControls.WpfGroup sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}