using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRowHeader
    /// </summary>
    public class WinRowHeader : WinControl<CUITControls.WinRowHeader>
    {
        public WinRowHeader(CUITControls.WinRowHeader sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinRowHeader(), searchProperties)
        {
        }

        public bool Selected
        {
            get { return SourceControl.Selected; }
        }
    }
}