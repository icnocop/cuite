using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlPassword : HtmlEdit
    {
        public HtmlPassword()
        {
        }

        public HtmlPassword(string searchParameters)
            : base(searchParameters)
        {
        }

        public override void Wrap(object control)
        {
            base.Wrap(control);
            _control = control as CUITControls.HtmlEdit;
            _control.FilterProperties[CUITControls.HtmlControl.PropertyNames.Type] = "PASSWORD";
        }
    }
}