using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ObjectRepository
{
    /// <summary>
    /// Abstract class representing a screen or window component in a WPF or WinForms
    /// application.
    /// </summary>
    /// <remarks>
    /// A <see cref="Screen"/> with a overwhelming number of controls can be split into logical
    /// components, thus providing better test code maintainability.
    /// </remarks>
    public abstract class ScreenComponent
    {
        private ApplicationUnderTest application;
        private UITestControl searchLimitContainer;

        /// <summary>
        /// Gets the application.
        /// </summary>
        public ApplicationUnderTest Application
        {
            get { return application; }
            internal set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                application = value;
            }
        }

        /// <summary>
        /// Gets or sets the search limit container.
        /// </summary>
        internal virtual UITestControl SearchLimitContainer
        {
            get { return searchLimitContainer; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                searchLimitContainer = value;
            }
        }

        /// <summary>
        /// Gets the screen component of specified type.
        /// </summary>
        /// <remarks>
        /// A <see cref="Screen"/> with a overwhelming number of controls can be split into logical
        /// components, thus providing better test code maintainability.
        /// </remarks>
        /// <typeparam name="T">The type of the screen component.</typeparam>
        /// <returns>The screen component of specified type.</returns>
        protected T GetComponent<T>() where T : ScreenComponent, new()
        {
            return new T
            {
                Application = Application,
                SearchLimitContainer = SearchLimitContainer
            };
        }

        /// <summary>
        /// Navigates to a new screen.
        /// </summary>
        /// <typeparam name="T">The type of screen to navigate to.</typeparam>
        /// <returns>The new screen.</returns>
        protected T NavigateTo<T>() where T : Screen, new()
        {
            return new T
            {
                Application = Application,
                SearchLimitContainer = Application
            };
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
            if (searchLimitContainer == null)
                throw new InvalidOperationException("The screen component has not been configured with a search limit container.");

            return searchLimitContainer.Find<T>(searchConfiguration);
        }
    }
}