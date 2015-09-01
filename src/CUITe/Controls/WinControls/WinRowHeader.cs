using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRowHeader
    /// </summary>
    public class WinRowHeader : WinControl<CUITControls.WinRowHeader>
    {
        public WinRowHeader(string searchProperties = null)
            : this(new CUITControls.WinRowHeader(), searchProperties)
        {
        }

        public WinRowHeader(CUITControls.WinRowHeader sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public bool Selected
        {
            get { return SourceControl.Selected; }
        }
    }
}