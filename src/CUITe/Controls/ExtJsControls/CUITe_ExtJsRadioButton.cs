using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using CUITe.Controls.ExtJsControls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace CUITe.Controls.ExtJsControls
{
    public class CUITe_ExtJsRadioButton : CUITe_HtmlControl<HtmlButton>
    {
        public CUITe_ExtJsRadioButton() : base() { }
        public CUITe_ExtJsRadioButton(string searchParameters) : base(searchParameters) { }



        public string IdbyItemid(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId, string Idsuffix)
        {
            
                this._control.WaitForControlReady();
                object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#"+ItemId+"')[0].id;");
                return Id.ToString()+Idsuffix;
            
        }

        public bool selected(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId)
        {
            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + ItemId + "')[0].getValue( );");
            bool State = (bool)Id;
            return State;
        }

        

    }
}
