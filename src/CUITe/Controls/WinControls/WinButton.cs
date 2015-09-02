using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinButton
    /// </summary>
    public class WinButton : WinControl<CUITControls.WinButton>
    {
        public WinButton(By searchConfiguration = null)
            : this(new CUITControls.WinButton(), searchConfiguration)
        {
        }

        public WinButton(CUITControls.WinButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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