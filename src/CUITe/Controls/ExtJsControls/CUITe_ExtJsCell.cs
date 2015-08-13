using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using CUITe.Extensions;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace CUITe.Extensions.Controls.ExtJsControls
{
    public class CUITe_ExtJsCell : CUITe_HtmlControl<HtmlCell>
    {
        public CUITe_ExtJsCell() : base() { }
        public CUITe_ExtJsCell(string sSearchProperties) : base(sSearchProperties) { }
        public CUITe_ExtJsCell(HtmlControl control) : base(control) { }

        public string IdbyName(CUITe_BrowserWindow objrepositoryclass_obj, string name, string Idsuffix)
        {

            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('[name=" + name + "]')[0].id;");
            return Id.ToString() + Idsuffix;

        }


    }
}
