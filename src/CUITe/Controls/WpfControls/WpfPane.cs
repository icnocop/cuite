using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfPane
    /// </summary>
    public class WpfPane : WpfControl<CUITControls.WpfPane>
    {
        public WpfPane(string searchProperties = null)
            : this(new CUITControls.WpfPane(), searchProperties)
        {
        }

        public WpfPane(CUITControls.WpfPane sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}