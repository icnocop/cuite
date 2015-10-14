using System;
using CUITe.Controls;
using CUITe.Controls.HtmlControls.Telerik;
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
        /// <exception cref="InvalidSearchPropertyNamesException">
        /// Search configuration contains a property namely that isn't applicable on the control.
        /// </exception>
        public static T Find<T>(this UITestControl self, By searchConfiguration = null) where T : ControlBase
        {
            if (self == null)
                throw new ArgumentNullException("self");
            
            var control = ControlBaseFactory.Create<T>(searchConfiguration);

            // TODO: This assembly should have no knowledge of the Silverlight assembly
            if (typeof(T).Namespace.Equals("CUITe.Controls.SilverlightControls"))
            {
                control.SourceControl.Container = FindSilverlightContainer(self);
            }
            else if (typeof(T).Namespace.Equals(typeof(ComboBox).Namespace))
            {
                (control as ComboBox).SetWindow(FindBrowserWindow(self));
            }
            else
            {
                control.SourceControl.Container = self;
            }

            return control;
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