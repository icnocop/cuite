using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlInputButton : HtmlControl<CUITControls.HtmlInputButton>
    {
        public HtmlInputButton()
        {
        }

        public HtmlInputButton(string searchParameters)
            : base(searchParameters)
        {
        }

        public string DisplayText
        {
            get { return _control.DisplayText; }
        }
    }
}