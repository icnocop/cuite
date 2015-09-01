using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinButton
    /// </summary>
    public class WinButton : WinControl<CUITControls.WinButton>
    {
        public WinButton(string searchProperties = null)
            : this(new CUITControls.WinButton(), searchProperties)
        {
        }

        public WinButton(CUITControls.WinButton sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        public string Shortcut
        {
            get { return SourceControl.Shortcut; }
        }
    }
}