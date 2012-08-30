using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;
using CUITe.Controls.TelerikControls;
using CUITe.Controls;

namespace CUITe
{
    public class ObjectRepositoryManager
    {
        public static T GetInstance<T>()
        {
            return (T)(object)GetInstance(typeof(T));
        }

        public static T GetInstance<T>(params object[] args)
        {
            return (T)(object)ObjectRepositoryManager.GetInstance(typeof(T), args);
        }

        private static CUITe_BrowserWindow GetInstance(Type typePageDefinition)
        {
            return GetInstance(typePageDefinition, null);
        }

        private static CUITe_BrowserWindow GetInstance(Type typePageDefinition, params object[] args)
        {
            CUITe_BrowserWindow browserWindow = (CUITe_BrowserWindow)Activator.CreateInstance(typePageDefinition, args);

            browserWindow.SetWindowTitle(typePageDefinition.GetField("sWindowTitle").GetValue(browserWindow).ToString());

            FieldInfo[] finfo = browserWindow.GetType().GetFields();
            foreach (FieldInfo fieldinfo in finfo) 
            {
                Type fieldType = fieldinfo.FieldType;

                if (fieldType.IsAssignableFrom(typeof(Telerik_ComboBox)))
                {
                    Telerik_ComboBox field = (Telerik_ComboBox)fieldinfo.GetValue(browserWindow);
                    field.SetWindow(browserWindow);
                }
                else if (fieldType.GetInterfaces().Contains(typeof(ICUITe_ControlBase)))
                {
                    ICUITe_ControlBase field = (ICUITe_ControlBase)fieldinfo.GetValue(browserWindow);

                    if (field.GetBaseType().IsSubclassOf(typeof(HtmlControl)))
                    {
                        field.Wrap(Activator.CreateInstance(field.GetBaseType(), new object[] { browserWindow }));
                    }
                    else if (field.GetBaseType().IsSubclassOf(typeof(SilverlightControl)))
                    {
                        field.Wrap(Activator.CreateInstance(field.GetBaseType(), new object[] { browserWindow.SlObjectContainer }));
                    }
                }
            }
            return browserWindow;
        }
    }
}