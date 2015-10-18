using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ObjectRepository
{
    /// <summary>
    /// Abstract class representing a page component in a HTML application.
    /// </summary>
    /// <remarks>
    /// A <see cref="Page"/> with a overwhelming number of controls can be split into logical
    /// components, thus providing better test code maintainability.
    /// </remarks>
    public abstract class PageComponent
    {
        private BrowserWindow browser;
        private UITestControl searchLimitContainer;

        /// <summary>
        /// Gets the browser.
        /// </summary>
        public BrowserWindow Browser
        {
            get { return browser; }
            internal set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                browser = value;
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
        /// Gets the page component of specified type.
        /// </summary>
        /// <remarks>
        /// A <see cref="Page"/> with a overwhelming number of controls can be split into logical
        /// components, thus providing better test code maintainability.
        /// </remarks>
        /// <typeparam name="T">The type of the page component.</typeparam>
        /// <returns>The page component of specified type.</returns>
        protected T GetComponent<T>() where T : PageComponent, new()
        {
            return new T
            {
                Browser = Browser,
                SearchLimitContainer = SearchLimitContainer
            };
        }

        /// <summary>
        /// Navigates to a new page.
        /// </summary>
        /// <typeparam name="T">The type of page to navigate to.</typeparam>
        /// <returns>The new page.</returns>
        protected T NavigateTo<T>() where T : Page, new()
        {
            return new T
            {
                Browser = Browser,
                SearchLimitContainer = Browser
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
                throw new InvalidOperationException("The page component has not been configured with a search limit container.");

            return searchLimitContainer.Find<T>(searchConfiguration);
        }
    }
}