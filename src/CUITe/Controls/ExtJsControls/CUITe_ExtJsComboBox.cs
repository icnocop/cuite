using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using CUITe.Extensions;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace CUITe.Extensions.Controls.ExtJsControls
{
    public class CUITe_ExtJsComboBox : CUITe_HtmlControl<HtmlEdit>
    {
        public CUITe_ExtJsComboBox() : base() { }
        public CUITe_ExtJsComboBox(string searchParameters) : base(searchParameters) { }


        public string IdbyItemid(CUITe_BrowserWindow objrepositoryclass_obj, string ItemId, string Idsuffix)
        {

            this._control.WaitForControlReady();
            object Id = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + ItemId + "')[0].id;");
            return Id.ToString() + Idsuffix;

        }


        //The below code is for using fireevent with ComboBox and can be utilized to create a funtion later (as required)//
        //WR_ReDesign_obj.ExecuteScript("Ext.ComponentQuery.query('#" + "cboCategory" + "')[0].fireEvent('select', {});");//
        public string  GetComboSelectedItem(CUITe_BrowserWindow objrepositoryclass_obj, string itemid)
        {
            object  comboboxitem=objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getValue();");
            return Convert.ToString(comboboxitem);
        }

        public string[] GetComboItems(CUITe_BrowserWindow objrepositoryclass_obj, string itemid)
        {
            string[] s = new string[500];
            object test = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getCount();");
            int numberofIndexvalues = Convert.ToInt32(test);

            for (int i = 0; i < numberofIndexvalues; i++)
            {
                //object test1 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getAt(" + i + ").get('Id');");
                //int Index_Value = Convert.ToInt32(test1);

                //objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].setValue(" + Index_Value + ");");

                object t=objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getAt(" + i + ").get('value');");
                s[i] = Convert.ToString(t);

                              
            }
            return s;
        }


        public bool SelectItem_index(CUITe_BrowserWindow objrepositoryclass_obj,  string itemid,string ListItem)
        {
            bool found = false;
          
            try
             {
                 object test = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getCount();");
                 int numberofIndexvalues = Convert.ToInt32(test);

                 for (int i = 0; i < numberofIndexvalues; i++)
                {
                    object test1 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getAt(" + i + ").get('Id');");
                    int Index_Value = Convert.ToInt32(test1);

                    objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].setValue(" + Index_Value + ");");

                   // objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getValue();");
                    

                    //if (name.GetText().ToString().Equals(ListItem))
                    //{
                    //    break;
                    //}

                    String comboBox_text = this._control.Text.ToString();

                    if (comboBox_text.Equals(ListItem))
                    {
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



        public bool SelectItem_GUID(CUITe_BrowserWindow objrepositoryclass_obj, string itemid, string ListItem)
        {
            bool found = false;

            try
            {
                object test = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getCount();");
                //object test2 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore(1);");
                //object test3 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getValue();");
                int numberofGUIDvalues = Convert.ToInt32(test);
                

                for (int i = 0; i < numberofGUIDvalues; i++)
                {
                    // objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getValue();");
                    object test1 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getAt(" + i + ").get('Id');");
                    
                    String GUID_Value = Convert.ToString(test1);

                    objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].setValue('" + GUID_Value + "');");

                    //if (name.GetText().ToString().Equals(ListItem))
                    //{
                    //    break;
                    //}

                    
                    String comboBox_text = this._control.Text.ToString();

                    if (comboBox_text.Equals(ListItem))
                    {
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


        public bool SelectItem_GUID_Custom(CUITe_BrowserWindow objrepositoryclass_obj, string itemid, string ListItem)
        {
            bool found = false;

            try
            {
                object test = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getCount();");

                               //object test2 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore(1);");
                //object test3 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getValue();");
                int numberofGUIDvalues = Convert.ToInt32(test);


                for (int i = 0; i < numberofGUIDvalues; i++)
                {
                    // objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getValue();");
                    object test1 = objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].getStore().getAt(" + i + ").get('id');");

                    String GUID_Value = Convert.ToString(test1);

                    objrepositoryclass_obj.ExecuteScript("return Ext.ComponentQuery.query('#" + itemid + "')[0].setValue('" + GUID_Value + "');");

                    //if (name.GetText().ToString().Equals(ListItem))
                    //{
                    //    break;
                    //}


                    String comboBox_text = this._control.Text.ToString();

                    if (comboBox_text.Equals(ListItem))
                    {
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


        //public void SelectItemException(string ListItem)
        //{


        //        this._control.WaitForControlEnabled();
        //        this._control.Find();   
        //        //this._control.SetProperty("Text", ListItem);
        //        Keyboard.SendKeys(this._control, ListItem);
           
        //}

        //public void SetText(string sText)
        //{
        //    this._control.WaitForControlReady();
        //    this._control.Text = sText;
        //}

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
