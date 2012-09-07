using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using SHDocVw;
using System.Linq;

namespace CUITe.Controls
{
    /// <summary>
    /// Factory class for creating CUITe* objects
    /// </summary>
    public class CUITe_ControlBaseFactory
    {
        public static T Create<T>(string sSearchProperties = null)
            where T : ICUITe_ControlBase
        {
            Type type = typeof(T);

            if (sSearchProperties == null)
            {
                return (T)Activator.CreateInstance(type);
            }
            else
            {
                return (T)Activator.CreateInstance(type, new object[] { sSearchProperties });
            }
        }
    }

    /// <summary>
    /// Base wrapper class for all CUITe* controls
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CUITe_ControlBase<T> : ICUITe_ControlBase
        where T : UITestControl
    {
        protected T _control;
        private string _SearchProperties;

        public CUITe_ControlBase() { }
        public CUITe_ControlBase(string sSearchProperties) 
        {
            if (sSearchProperties == null) throw new Exception("Parameter 'SearchProperties' cannot be null");
            this._SearchProperties = sSearchProperties;
            if (this._SearchProperties.Substring(this._SearchProperties.Length - 1) == ";")
            {
                this._SearchProperties = this._SearchProperties.Substring(0, this._SearchProperties.Length - 1);
            }
        }

        public T Get<T>() where T : ICUITe_ControlBase
        {
            T control = CUITe_ControlBaseFactory.Create<T>();

            var baseControl = Activator.CreateInstance(control.GetBaseType(), new object[] { this.UnWrap() });

            control.Wrap(baseControl);

            return control;
        }

        /// <summary>
        /// Gets the CUITe UI control object from the descendants of this control using the search parameters are passed. 
        /// You don't have to create the object repository entry for this.
        /// </summary>
        /// <typeparam name="T">Pass the CUITe control you are looking for.</typeparam>
        /// <param name="searchParameters">In 'Key1=Value1;Key2=Value2' format. For example 'Id=firstname' 
        /// or use '~' for Contains such as 'Id~first'</param>
        /// <returns>CUITe_* control object</returns>
        public T Get<T>(string searchParameters) where T : ICUITe_ControlBase
        {
            T control = CUITe_ControlBaseFactory.Create<T>(searchParameters);

            var baseControl = Activator.CreateInstance(control.GetBaseType(), new object[] { this.UnWrap() });

            control.Wrap(baseControl);

            return control;
        }

        /// <summary>
        /// Get the Coded UI base type that is being wrapped by CUITe
        /// </summary>
        /// <returns></returns>
        public Type GetBaseType()
        {
            return typeof(T);
        }

        /// <summary>
        /// Wraps the provided UITestControl in a CUITe object. 
        /// Fills the Coded UI control's search properties using values 
        /// set when the CUITe object was created.
        /// </summary>
        /// <param name="control"></param>
        public virtual void Wrap(object control)
        {
            this._control = control as T;
            this.fillSearchProperties();
            this._control.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
        }

        /// <summary>
        /// UnWraps the CUITe* controls to expose the underlying UITestControl.
        /// This helps when you want to use any methods/properties of the underlying UITestControl.
        /// CUITe* controls are wrappers/abstractions which hides complexity. UnWrap() helps you break the abstraction.
        /// </summary>
        /// <returns>The underlying UITestControl instance. For example, returns HtmlEdit in case of CUITe_HtmlEdit.</returns>
        public T UnWrap()
        {
            return this._control;
        }

        /// <summary>
        /// Wraps the provided UITestControl in a CUITe object.
        /// It does nothing with the control's search properties.
        /// </summary>
        /// <param name="control"></param>
        public void WrapReady(object control)
        {
            this._control = control as T;
        }

        /// <summary>
        /// Wraps the WaitForControlReady method for a UITestControl.
        /// </summary>
        public void WaitForControlReady()
        {
            this._control.WaitForControlReady();
        }

        /// <summary>
        /// Wraps WaitForControlReady and Click methods for a UITestControl.
        /// </summary>
        public void Click()
        {
            this._control.WaitForControlReady();
            Mouse.Click(this._control);
        }

        /// <summary>
        /// Wraps WaitForControlReady and DoubleClick methods for a UITestControl.
        /// </summary>
        public void DoubleClick()
        {
            this._control.WaitForControlReady();
            Mouse.DoubleClick(this._control);
        }

        /// <summary>
        /// Wraps WaitForControlReady method and Enabled property for a UITestControl.
        /// </summary>
        public bool Enabled
        {
            get 
            {
                this._control.WaitForControlReady();
                return this._control.Enabled; 
            }
        }

        /// <summary>
        /// Wraps the Exists property for a UITestControl.
        /// </summary>
        public bool Exists
        {
            get 
            {
                if (this._control == null)
                {
                    return false;
                }

                return this._control.Exists; 
            }
        }

        /// <summary>
        /// Wraps WaitForControlReady and SetFocus methods for a UITestControl.
        /// </summary>
        public void SetFocus()
        {
            this._control.WaitForControlReady();
            this._control.SetFocus();
        }

        /// <summary>
        /// Wraps the adding of search properties for the UITestControl where
        /// the property expression is 'EqualTo'.
        /// </summary>
        /// <param name="sPropertyName"></param>
        /// <param name="sValue"></param>
        public void SetSearchProperty(string sPropertyName, string sValue)
        {
            this._control.SearchProperties.Add(sPropertyName, sValue, PropertyExpressionOperator.EqualTo);
        }

        /// <summary>
        /// Wraps the adding of search properties for the UITestControl where
        /// the property expression is 'Contains'.
        /// </summary>
        /// <param name="sPropertyName"></param>
        /// <param name="sValue"></param>
        public void SetSearchPropertyRegx(string sPropertyName, string sValue)
        {
            this._control.SearchProperties.Add(sPropertyName, sValue, PropertyExpressionOperator.Contains);
        }

        /// <summary>
        /// Fills the UITestControl's search properties based on search string provided when the CUITe
        /// object was created.
        /// </summary>
        protected void fillSearchProperties()
        {
            // iterate through the class inheritance hierarchy to get a list of property names for the specific control
            // Note: Some properties may not be valid to use for search (ex. filter property names). MS does not provide and exact list
            List<FieldInfo> controlProperties = new List<FieldInfo>();

            Type nestedType = typeof(T);
            Type nestedPropertyNamesType = nestedType.GetNestedType("PropertyNames");

            while (nestedType != typeof(object))
            {
                if (nestedPropertyNamesType != null)
                {
                    controlProperties.AddRange(nestedPropertyNamesType.GetFields());
                }

                nestedType = nestedType.BaseType;
                nestedPropertyNamesType = nestedType.GetNestedType("PropertyNames");
            }

            if (!string.IsNullOrEmpty(this._SearchProperties))
            {
                // Split on groups of key/value pairs
                string[] saKeyValuePairs = this._SearchProperties.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string sKeyValue in saKeyValuePairs)
                {
                    PropertyExpressionOperator compareOperator = PropertyExpressionOperator.EqualTo;

                    // If split on '=' does not work, then try '~'
                    string[] saKeyVal = sKeyValue.Split('=');
                    if (saKeyVal.Length != 2)
                    {
                        // Otherwise try to split on '~'. If it works then compare type is Contains
                        saKeyVal = sKeyValue.Split('~');
                        if (saKeyVal.Length == 2)
                        {
                            compareOperator = PropertyExpressionOperator.Contains;
                        }
                        else
                        {
                            throw new CUITe_InvalidSearchParameterFormat(this._SearchProperties);
                        }
                    }

                    // Find the first property in the list of known values
                    string valueName = saKeyVal[0];

                    if ((this._control is HtmlControl) && (valueName.Equals("Value", StringComparison.OrdinalIgnoreCase)))
                    {
                        //support for backward compatibility where search properties like "Value=Log In" are used
                        valueName += "Attribute";
                    }

                    FieldInfo foundField = controlProperties.Find(
                        searchProperty => searchProperty.Name.Equals(valueName, StringComparison.OrdinalIgnoreCase));

                    if (foundField == null)
                    {
                        throw new CUITe_InvalidSearchKey(valueName, this._SearchProperties, controlProperties.Select(x => x.Name).ToList());
                    }

                    // Add the search property, value and type
                    this._control.SearchProperties.Add(foundField.GetValue(null).ToString(), saKeyVal[1], compareOperator);
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
