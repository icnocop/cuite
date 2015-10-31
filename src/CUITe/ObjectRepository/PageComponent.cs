using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ObjectRepository
{
    /// <summary>
    /// Abstract class representing a page component in a HTML or Silverlight application.
    /// </summary>
    /// <remarks>
    /// A <see cref="Page"/> with a overwhelming number of controls can be split into logical
    /// components, thus providing better test code maintainability.
    /// </remarks>
    /// <seealso cref="Page"/>
    /// <seealso cref="PageComponent{T}"/>
    public abstract class PageComponent : ViewComponent
    {
        private BrowserWindow browser;
        
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
    }
}