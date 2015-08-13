using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using CUITe.Controls.ExtJsControls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;


namespace CUITe.Controls.ExtJsControls
{
    public class CUITe_ExtJsButton : CUITe_HtmlControl<HtmlButton>
    {
        public CUITe_ExtJsButton() : base() { }
        public CUITe_ExtJsButton(string searchParameters) : base(searchParameters) { }

        //public bool Checked
        //{
        //    get
        //    {
        //        this._control.WaitForControlReady();
        //        return this._control.Checked;
        //    }
        //}


        public string IdbyItemid(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId, string Idsuffix)
        {
            
                this._control.WaitForControlReady();
                object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#"+ItemId+"')[0].id;");
                return Id.ToString()+Idsuffix;
            
        }

        public bool Checked(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId)
        {
            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + ItemId + "')[0].getValue( );");
            bool State = (bool)Id;
            return State;
        }

        public string IdbyName(CUITe_BrowserWindow objrepositoryclass_obj, string name, string Idsuffix)
        {

            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('[name=" + name + "]')[0].id;");
            return Id.ToString() + Idsuffix;

        }

        

    }
}
