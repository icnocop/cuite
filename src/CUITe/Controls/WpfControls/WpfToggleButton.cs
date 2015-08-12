using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToggleButton
    /// </summary>
    public class WpfToggleButton : WpfControl<CUIT.WpfToggleButton>
    {
        public WpfToggleButton() : base() { }
        public WpfToggleButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }

        public bool Indeterminate
        {
            get { return this.UnWrap().Indeterminate; }
            set { this.UnWrap().Indeterminate = value; }
        }

        public bool Pressed
        {
            get { return this.UnWrap().Pressed; }
            set { this.UnWrap().Pressed = value; }
        }
        
    }
}