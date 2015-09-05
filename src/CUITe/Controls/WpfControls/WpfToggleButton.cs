using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToggleButton
    /// </summary>
    public class WpfToggleButton : WpfControl<CUITControls.WpfToggleButton>
    {
        public WpfToggleButton(By searchConfiguration = null)
            : this(new CUITControls.WpfToggleButton(), searchConfiguration)
        {
        }

        public WpfToggleButton(CUITControls.WpfToggleButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
        }

        public bool Pressed
        {
            get { return SourceControl.Pressed; }
            set { SourceControl.Pressed = value; }
        }
    }
}