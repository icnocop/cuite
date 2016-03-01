using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.PageObjects
{
    /// <summary>
    /// Abstract class representing a page object in a HTML or Silverlight application.
    /// </summary>
    /// <remarks>
    /// A <see cref="Page"/> with a overwhelming number of controls can be split into logical
    /// page objects, thus providing better test code maintainability.
    /// </remarks>
    /// <seealso cref="Page"/>
    /// <seealso cref="PageObject{T}"/>
    public abstract class PageObject : ViewObject
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
        /// Gets the page object of specified type.
        /// </summary>
        /// <remarks>
        /// A <see cref="Page"/> with a overwhelming number of controls can be split into logical
        /// page objects, thus providing better test code maintainability.
        /// </remarks>
        /// <typeparam name="T">The type of the page object.</typeparam>
        /// <returns>The page object of specified type.</returns>
        protected T GetPageObject<T>() where T : PageObject, new()
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