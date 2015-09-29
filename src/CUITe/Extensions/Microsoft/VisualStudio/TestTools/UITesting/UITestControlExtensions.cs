using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;

// ReSharper disable once CheckNamespace
namespace Microsoft.VisualStudio.TestTools.UITesting
{
    /// <summary>
    /// Class containing extensions methods for <see cref="UITestControl"/>.
    /// </summary>
    internal static class UITestControlExtensions
    {
        /// <summary>
        /// Finds the control object from the descendants of specified control using the specified
        /// search configuration.
        /// </summary>
        /// <typeparam name="T">The type of control to find.</typeparam>
        /// <param name="source">The control whose descendants to search.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <exception cref="InvalidSearchPropertyNamesException">
        /// Search configuration contains a property namely that isn't applicable on the control.
        /// </exception>
        internal static T Find<T>(this UITestControl source, By searchConfiguration = null) where T : ControlBase
        {
            if (source == null)
                throw new ArgumentNullException("source");

            var control = ControlBaseFactory.Create<T>(searchConfiguration);
            control.SourceControl.Container = source;
            return control;
        }
    }
}