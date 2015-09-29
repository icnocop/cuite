using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Mappings
{
    /// <summary>
    /// Abstract class representing a screen or a window in a WPF or WinForms application.
    /// </summary>
    public abstract class Screen
    {
        private readonly UITestControl searchLimitContainer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Screen"/> class.
        /// </summary>
        /// <param name="searchLimitContainer">Container for locating controls.</param>
        protected Screen(UITestControl searchLimitContainer)
        {
            if (searchLimitContainer == null)
                throw new ArgumentNullException("searchLimitContainer");

            this.searchLimitContainer = searchLimitContainer;
        }

        /// <summary>
        /// Finds the control object from the descendants of this control using the specified
        /// search configuration.
        /// </summary>
        /// <typeparam name="T">The type of control to find.</typeparam>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <exception cref="InvalidSearchPropertyNamesException">
        /// Search configuration contains a property namely that isn't applicable on the control.
        /// </exception>
        protected T Find<T>(By searchConfiguration = null) where T : ControlBase
        {
            return searchLimitContainer.Find<T>(searchConfiguration);
        }
    }
}