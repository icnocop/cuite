using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using CUITe.Controls.ExtJsControls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace CUITe.Controls.ExtJsControls
{
    public class CUITe_ExtJSFrame : CUITe_HtmlControl<HtmlFrame>
    {
        public CUITe_ExtJSFrame() : base() { }
        public CUITe_ExtJSFrame(string searchParameters) : base(searchParameters) { }

        public void SetFocus()
        {
            this._control.WaitForControlReady();
            this._control.SetFocus();
        }

        
    }
}
