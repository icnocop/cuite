using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlInputButton : CUITe_HtmlControl<HtmlInputButton>
    {
        public CUITe_HtmlInputButton() : base() { }
        public CUITe_HtmlInputButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get
            {
                return this._control.DisplayText;
            }
        }
    }
}
