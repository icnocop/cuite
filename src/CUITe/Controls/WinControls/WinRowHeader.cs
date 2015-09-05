using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRowHeader
    /// </summary>
    public class WinRowHeader : WinControl<CUITControls.WinRowHeader>
    {
        public WinRowHeader(By searchConfiguration = null)
            : this(new CUITControls.WinRowHeader(), searchConfiguration)
        {
        }

        public WinRowHeader(CUITControls.WinRowHeader sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public bool Selected
        {
            get { return SourceControl.Selected; }
        }
    }
}