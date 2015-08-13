using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using CUITe.Extensions;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace CUITe.Extensions.Controls.ExtJsControls
{
    public class CUITe_ExtJsTextBox : CUITe_HtmlControl<HtmlEdit>
    {
        public CUITe_ExtJsTextBox() : base() { }
        public CUITe_ExtJsTextBox(string searchParameters) : base(searchParameters) { }

       

        public string Id(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId, string Idsuffix)
        {
            
                this._control.WaitForControlReady();
                object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#"+ItemId+"')[0].id;");
                return Id.ToString()+Idsuffix;
            
        }

        public string IdbyName(CUITe_BrowserWindow objrepositoryclass_obj, string name, string Idsuffix)
        {
            
            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#[name="+name+"]')[0].id;");
            return Id.ToString() + Idsuffix;

        }

        public void SetText(string sText)
        {
            this._control.WaitForControlReady();
            this._control.Text = sText;
        }

        public string GetText()
        {
            this._control.WaitForControlReady();
            return this._control.Text;
        }

        public bool ReadOnly
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ReadOnly;
            }
        }
      
        

    }
}
