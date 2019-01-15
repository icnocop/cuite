using System;
using CUITe.Controls;
using CUITe.Controls.HtmlControls.Telerik;
using CUITe.Controls.WinControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

// ReSharper disable once CheckNamespace
namespace Microsoft.VisualStudio.TestTools.UITesting
{
    /// <summary>
    /// Class containing extensions methods for <see cref="UITestControl"/>.
    /// </summary>
    public static class UITestControlExtensions
    {
        /// <summary>
        /// Finds the control object from the descendants of specified control using the specified
        /// search configuration.
        /// </summary>
        /// <typeparam name="T">The type of control to find.</typeparam>
        /// <param name="self">The control whose descendants to search.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public static T Find<T>(this UITestControl self, By searchConfiguration = null) where T : ControlBase
        {
            if (self == null)
                throw new ArgumentNullException("self");

            T control;

            // TODO: This assembly should have no knowledge of the Silverlight assembly
            if (typeof(T).Namespace.Equals("CUITe.Controls.SilverlightControls"))
            {
                if (self is BrowserWindow)
                {
                    UITestControl silverlightObject = FindSilverlightContainer(self);
                    control = ControlBaseFactory.Create<T>(silverlightObject, searchConfiguration);
                }
                else
                {
                    control = ControlBaseFactory.Create<T>(self, searchConfiguration);
                }
            }
            else
            {
                control = ControlBaseFactory.Create<T>(searchConfiguration);

                if (typeof(T).Namespace.Equals(typeof(ComboBox).Namespace))
                {
                    (control as ComboBox).SetWindow(FindBrowserWindow(self));
                }
                else
                {
                    control.SourceControl.Container = self;

                    if ((searchConfiguration != null)
                        && IsSubclassOfRawGeneric(typeof(WinControl<>), control.GetType()))
                    {
                        control.SourceControl.SearchProperties.AddRange(searchConfiguration.Configuration);
                    }
                }
            }

            return control;
        }

        private static bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
        {
            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }

        private static UITestControl FindSilverlightContainer(UITestControl control)
        {
            BrowserWindow browserWindow = FindBrowserWindow(control);
            if (browserWindow != null)
            {
                var custom = new HtmlCustom(browserWindow);
                custom.SearchProperties["TagName"] = "OBJECT";
                return custom;
            }
            
            return control.GetParent();
        }

        private static BrowserWindow FindBrowserWindow(UITestControl control)
        {
            while (control != null)
            {
                var browserWindow = control as BrowserWindow;
                if (browserWindow != null)
                    return browserWindow;

                control = control.GetParent();
            }

            return null;
        }
    }
}