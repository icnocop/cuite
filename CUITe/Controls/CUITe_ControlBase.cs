using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using SHDocVw;
using mshtml;

namespace CUITe.Controls
{
    public class CUITe_ControlBaseFactory
    {
        public static T Create<T>(string sSearchProperties)
            where T : ICUITe_ControlBase
        {
            Type type = typeof(T);

            return (T)Activator.CreateInstance(type, new object[]{sSearchProperties});
        }
    }

    public class CUITe_ControlBase<T> : ICUITe_ControlBase
        where T : UITestControl
    {
        public T _control;
        private string _SearchProperties;

        public CUITe_ControlBase() { }
        public CUITe_ControlBase(string sSearchProperties) 
        {
            if (sSearchProperties == null) throw new Exception("Parameter 'SearchProperties' cannot be null");
            this._SearchProperties = sSearchProperties.Trim();
            if (this._SearchProperties.Substring(this._SearchProperties.Length - 1) == ";")
            {
                this._SearchProperties = this._SearchProperties.Substring(0, this._SearchProperties.Length - 1);
            }
        }

        public Type GetBaseType()
        {
            return typeof(T);
        }

        public virtual void Wrap(object control)
        {
            this._control = control as T;
            this.fillSearchProperties();
            this._control.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
        }

        public T UnWrap()
        {
            return this._control;
        }

        public void WrapReady(object control)
        {
            this._control = control as T;
        }

        public void WaitForControlReady()
        {
            this._control.WaitForControlReady();
        }

        public void Click()
        {
            this._control.WaitForControlReady();
            Mouse.Click(this._control);
        }

        public void DoubleClick()
        {
            this._control.WaitForControlReady();
            Mouse.DoubleClick(this._control);
        }

        public bool Enabled
        {
            get 
            {
                this._control.WaitForControlReady();
                return this._control.Enabled; 
            }
        }

        public bool Exists
        {
            get 
            {
                return this._control.Exists; 
            }
        }

        public void SetFocus()
        {
            this._control.WaitForControlReady();
            this._control.SetFocus();
        }

        public void SetSearchProperty(string sPropertyName, string sValue)
        {
            this._control.SearchProperties.Add(sPropertyName, sValue);
        }

        public void SetSearchPropertyRegx(string sPropertyName, string sValue)
        {
            this._control.SearchProperties.Add(sPropertyName, sValue, PropertyExpressionOperator.Contains);
        }

        private void fillSearchProperties()
        {
            if (this._SearchProperties != "*" && this._SearchProperties !=null)
            {
                string[] saKeyValuePairs = this._SearchProperties.Split(';');
                foreach (string sKeyValue in saKeyValuePairs)
                {
                    string[] saKeyVal = sKeyValue.Split('=');
                    if (saKeyVal.Length != 2) throw new CUITe_InvalidSearchParameterFormat(this._SearchProperties);
                    string sKey = saKeyVal[0].ToLower();
                    string sValue = saKeyVal[1];
                    if (sValue != "")
                    {
                        switch (sKey)
                        {
                            case "id":
                                this._control.SearchProperties.Add(HtmlControl.PropertyNames.Id, sValue);
                                break;
                            case "class":
                                this._control.SearchProperties.Add(HtmlControl.PropertyNames.Class, sValue);
                                break;
                            case "title":
                                this._control.SearchProperties.Add(HtmlControl.PropertyNames.Title, sValue);
                                break;
                            case "innertext":
                                this._control.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, sValue);
                                break;
                            case "name":
                                this._control.SearchProperties.Add(HtmlControl.PropertyNames.Name, sValue);
                                break;
                            case "href":
                                this._control.SearchProperties.Add(HtmlHyperlink.PropertyNames.Href, sValue);
                                break;
                            case "absolutepath":
                                this._control.SearchProperties.Add(HtmlImage.PropertyNames.AbsolutePath, sValue);
                                break;
                            case "automationid":
                                this._control.SearchProperties.Add(SilverlightControl.PropertyNames.AutomationId, sValue);
                                break;
                            case "text":
                                this._control.SearchProperties.Add(SilverlightText.PropertyNames.Text, sValue);
                                break;
                            case "value":
                                this._control.SearchProperties.Add(HtmlControl.PropertyNames.ValueAttribute, sValue);
                                break;
                            default:
                                throw new CUITe_InvalidSearchKey(saKeyVal[0], this._SearchProperties);
                        }
                    }
                }
            }
        }

        protected void RunScript(string sCode)
        {
            BrowserWindow _bw = (BrowserWindow)this._control.TopParent;
            InternetExplorer IE = null;
            ShellWindows shws = new ShellWindows();
            foreach (InternetExplorer shwin in shws)
            {
                if (shwin.HWND == _bw.WindowHandle.ToInt32())
                {
                    IE = shwin;
                    break;
                }
            }
            IE.Document.parentWindow.execScript(sCode);
        }
    }
}
