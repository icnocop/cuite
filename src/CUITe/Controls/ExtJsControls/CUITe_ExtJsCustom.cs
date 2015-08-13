using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Threading;
using CUITe.Extensions;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;


namespace CUITe.Extensions.Controls.ExtJsControls
{
    public class CUITe_ExtJsCustom : CUITe_HtmlControl<HtmlCustom>
    {

        //public void SetText(string sText)
        //{
        //    this._control.WaitForControlReady();
        //    this._control.Text = sText;
        //}

        //public string GetText()
        //{
        //    this._control.WaitForControlReady();
        //    return this._control.Text;
        //}




        public CUITe_ExtJsCustom(string tagName)
            : base()
        {
            Initialize(tagName);
        }

        public CUITe_ExtJsCustom(string tagName, string searchParameters)
            : base(searchParameters)
        {
            Initialize(tagName);
        }

        private void Initialize(string tagName)
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, tagName, PropertyExpressionOperator.EqualTo);
        }

        public string IdbyItemid(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId, string Idsuffix)
        {

            this._control.WaitForControlReady();
            
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + ItemId + "')[0].id;");
            return Id.ToString() + Idsuffix;



        }

        public string IdbyTitle(CUITe_BrowserWindow objrepositoryclass_obj, string Title, string Idsuffix)
        {

            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('tabpanel [title=" + Title + "]')[0].id;");
            return Id.ToString() + Idsuffix;



        }

        //public string IdbyName(CUITe_BrowserWindow objrepositoryclass_obj, string Name, string Idsuffix)
        //{

        //    this._control.WaitForControlReady();
        //    object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('tabpanel [name=" + Name + "]')[0].id;");
        //    return Id.ToString() + Idsuffix;

        //}

        public string IdbyName(CUITe_BrowserWindow objrepositoryclass_obj, string name, string Idsuffix)
        {

            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('[name=" + name + "]')[0].id;");
            return Id.ToString() + Idsuffix;

        }


        public int GetStoreCount_ByItemID(CUITe_BrowserWindow objrepositoryclass_obj, string itemid)
        {

            object b = new object();
            b = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getCount();");

            return (Convert.ToInt16(b));
        }


        public bool SelectProject_ByItemID(CUITe_BrowserWindow objrepositoryclass_obj, string itemid, string Project)
        {
            bool found = false;

            try
            {
                //Get the total count of projects from Intake-Specifications tab
                object ProjCnt = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getCount();");

                int ProjectNameCount = Convert.ToInt32(ProjCnt);

                for (int i = 0; i < ProjectNameCount; i++)
                {

                    object test66 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getAt(" + i + ").get('name');");
                    String projname = Convert.ToString(test66);

                    if (projname.Equals(Project))
                    {
                        //select the project name from the project list
                        objrepositoryclass_obj.ExecuteScript("Ext.ComponentQuery.query('#" + itemid + "')[0].getSelectionModel().select(" + i + ");");
                        Thread.Sleep(5000);
                        found = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                String trash = e.Message;
                throw;
            }

            return found;
        }
    }
}
