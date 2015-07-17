using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToggleButton
    /// </summary>
    public class CUITe_WpfToggleButton : CUITe_WpfControl<WpfToggleButton>
    {
        public CUITe_WpfToggleButton() : base() { }
        public CUITe_WpfToggleButton(string searchParameters) : base(searchParameters) { }

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