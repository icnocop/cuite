using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using CUITe.Controls.ExtJsControls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace CUITe.Controls.ExtJsControls
{
    public class CUITe_ExtJsLabel : CUITe_HtmlControl<HtmlLabel>
    {
        public CUITe_ExtJsLabel() : base() { }
        public CUITe_ExtJsLabel(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the name of the control that is associated with this label.
        /// </summary>
        /// <value>
        /// The name of the control that is associated with this label.
        /// </value>
        /// 

        public string IdbyItemid(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId, string Idsuffix)
        {

            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + ItemId + "')[0].id;");
            return Id.ToString() + Idsuffix;

        }

        public string LabelFor
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.LabelFor;
            }
        }
    }
}
