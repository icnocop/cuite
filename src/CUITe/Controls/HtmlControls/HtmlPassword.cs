using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlPassword : HtmlEdit
    {
        public HtmlPassword() : base() { }
        public HtmlPassword(string searchParameters) : base(searchParameters) { }

        public override void Wrap(object control)
        {
            base.Wrap(control);
            this._control = control as CUITControls.HtmlEdit;
            this._control.FilterProperties[CUITControls.HtmlEdit.PropertyNames.Type] = "PASSWORD";
        }
    }
}
