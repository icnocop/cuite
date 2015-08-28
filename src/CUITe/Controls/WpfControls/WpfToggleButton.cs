using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToggleButton
    /// </summary>
    public class WpfToggleButton : WpfControl<CUITControls.WpfToggleButton>
    {
        public WpfToggleButton(CUITControls.WpfToggleButton sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfToggleButton(), searchProperties)
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