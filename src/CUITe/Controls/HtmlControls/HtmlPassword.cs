using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlPassword : CUITe_HtmlEdit
    {
        public CUITe_HtmlPassword() : base() { }
        public CUITe_HtmlPassword(string searchParameters) : base(searchParameters) { }

        public override void Wrap(object control)
        {
            base.Wrap(control);
            this._control = control as HtmlEdit;
            this._control.FilterProperties[HtmlEdit.PropertyNames.Type] = "PASSWORD";
        }
    }
}
