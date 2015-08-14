using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToggleButton
    /// </summary>
    public class WpfToggleButton : WpfControl<CUITControls.WpfToggleButton>
    {
        public WpfToggleButton() { }
        public WpfToggleButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return UnWrap().DisplayText; }
        }

        public bool Indeterminate
        {
            get { return UnWrap().Indeterminate; }
            set { UnWrap().Indeterminate = value; }
        }

        public bool Pressed
        {
            get { return UnWrap().Pressed; }
            set { UnWrap().Pressed = value; }
        }
        
    }
}