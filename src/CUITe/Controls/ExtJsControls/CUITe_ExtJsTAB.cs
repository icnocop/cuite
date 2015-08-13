using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using CUITe.Extensions;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace CUITe.Extensions.Controls.ExtJsControls
{
    public class CUITe_ExtJsTAB : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_ExtJsTAB(string tagName)
            : base()
        {
            Initialize(tagName);
        }

        public CUITe_ExtJsTAB(string tagName, string searchParameters)
            : base(searchParameters)
        {
            Initialize(tagName);
        }

        private void Initialize(string tagName)
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, tagName, PropertyExpressionOperator.EqualTo);
        }

        public string Id(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId, int tabnumber, string Idsuffix)
        {

            this._control.WaitForControlReady();            
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('" + ItemId + "')["+tabnumber.ToString()+"].id;");
            return Id.ToString() + Idsuffix;

            

        }
    }
}
