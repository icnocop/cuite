using System;
using System.Linq;
using System.Reflection;
using CUITe.Controls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.TelerikControls;
using CUITHtmlControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
#if SILVERLIGHT_SUPPORT
using CUITSilverlightControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
#endif

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
            return (T)(object)GetInstance(typeof(T), args);
        }

        private static BrowserWindowUnderTest GetInstance(Type typePageDefinition)
        {
            return GetInstance(typePageDefinition, null);
        }

        private static BrowserWindowUnderTest GetInstance(Type typePageDefinition, params object[] args)
        {
            var browserWindow = (BrowserWindowUnderTest)Activator.CreateInstance(typePageDefinition, args);

            browserWindow.SetWindowTitle(typePageDefinition.GetField("sWindowTitle").GetValue(browserWindow).ToString());

            FieldInfo[] finfo = browserWindow.GetType().GetFields();
            foreach (FieldInfo fieldinfo in finfo)
            {
                Type fieldType = fieldinfo.FieldType;

                if (fieldType.IsAssignableFrom(typeof(ComboBox)))
                {
                    ComboBox field = (ComboBox)fieldinfo.GetValue(browserWindow);
                    field.SetWindow(browserWindow);
                }
                else if (fieldType.GetInterfaces().Contains(typeof(IControlBase)))
                {
                    IControlBase field = (IControlBase)fieldinfo.GetValue(browserWindow);

                    if (field.GetBaseType().IsSubclassOf(typeof(CUITHtmlControls.HtmlControl)))
                    {
                        field.Wrap(Activator.CreateInstance(field.GetBaseType(), browserWindow));
                    }
#if SILVERLIGHT_SUPPORT
                    else if ((field.GetBaseType() == typeof(CUITSilverlightControls.SilverlightControl)) ||
                             (field.GetBaseType().IsSubclassOf(typeof(CUITSilverlightControls.SilverlightControl))))
                    {
                        field.Wrap(Activator.CreateInstance(field.GetBaseType(), browserWindow.SlObjectContainer));
                    }
#endif
                }
            }
            return browserWindow;
        }
    }
}