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

            return (T)Activator.CreateInstance(type, new object[] { sSearchProperties });
        }
    }

    public class CUITe_ControlBase<T> : ICUITe_ControlBase
        where T : UITestControl
    {
        protected T _control;
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

        /// <summary>
        /// UnWraps the CUITe_Html* or CUITe_Sl* controls to expose the underlying UITestControl.
        /// This helps when you want to use any methods/properties of the underlying UITestControl.
        /// CUITe_Html* or CUITe_Sl* controls are wrappers/abstractions which hides complexity. UnWrap() helps you break the abstraction.
        /// </summary>
        /// <returns>The underlying UITestControl instance. For example, returns HtmlEdit in case of CUITe_HtmlEdit.</returns>
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

        protected void fillSearchProperties()
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
                                if (typeof(T).Namespace.Contains(".HtmlControls."))
                                {
                                    this._control.SearchProperties.Add(HtmlControl.PropertyNames.Name, sValue);
                                }
                                if (typeof(T).Namespace.Contains(".SilverlightControls."))
                                {
                                    this._control.SearchProperties.Add(SilverlightControl.PropertyNames.Name, sValue);
                                }
                                break;
                            case "value":
                                this._control.SearchProperties.Add(HtmlControl.PropertyNames.ValueAttribute, sValue);
                                break;
                            case "href":
                                this._control.SearchProperties.Add(HtmlHyperlink.PropertyNames.Href, sValue);
                                break;
                            case "absolutepath":
                                this._control.SearchProperties.Add(HtmlImage.PropertyNames.AbsolutePath, sValue);
                                break;
                            case "src":
                                if (typeof(T).Namespace.Contains(".HtmlControls."))
                                {
                                    this._control.SearchProperties.Add(HtmlImage.PropertyNames.Src, sValue);
                                }
                                if (typeof(T).Namespace.Contains(".SilverlightControls."))
                                {
                                    this._control.SearchProperties.Add(SilverlightImage.PropertyNames.Source, sValue);
                                }
                                break;
                            case "automationid":
                                this._control.SearchProperties.Add(SilverlightControl.PropertyNames.AutomationId, sValue);
                                break;
                            case "text":
                                this._control.SearchProperties.Add(SilverlightText.PropertyNames.Text, sValue);
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

        #region implementing parent, sibling etc methods as virtual

        public virtual ICUITe_ControlBase Parent { get { return null; } }

        public virtual ICUITe_ControlBase PreviousSibling { get { return null; } }

        public virtual ICUITe_ControlBase NextSibling { get { return null; } }

        public virtual ICUITe_ControlBase FirstChild { get { return null; } }

        public virtual List<ICUITe_ControlBase> GetChildren() { return null; }

        #endregion
    }
}
