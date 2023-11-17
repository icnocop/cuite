using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.PageObjects
{
    /// <summary>
    /// Abstract class representing a page in a HTML or Silverlight application.
    /// </summary>
    /// <seealso cref="PageObject"/>
    /// <seealso cref="PageObject{T}"/>
    public abstract class Page : PageObject
    {
        /// <summary>
        /// Launches a Web browser window by using the given URI and returns a page of type
        /// <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the page to return.</typeparam>
        /// <param name="uri">The URI to start the Web browser.</param>
        /// <returns>A page representing the launched application.</returns>
        public static T Launch<T>(string uri) where T : Page, new()
        {
            if (uri == null)
                throw new ArgumentNullException("uri");

            return Launch<T>(new Uri(uri));
        }

        /// <summary>
        /// Launches a Web browser window by using the given URI and returns a page of type
        /// <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the page to return.</typeparam>
        /// <param name="uri">The URI to start the Web browser.</param>
        /// <returns>A page representing the launched application.</returns>
        public static T Launch<T>(Uri uri) where T : Page, new()
        {
            if (uri == null)
                throw new ArgumentNullException("uri");

            var browser = BrowserWindow.Launch(uri);

            return new T
            {
                Browser = browser,
                SearchLimitContainer = browser
            };
        }

        /// <summary>
        /// Gets an instance of a page of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the page to return.</typeparam>
        /// <returns>The page.</returns>
        public static T Get<T>() where T : Page, new()
        {
            BrowserWindow browser = new BrowserWindow();
            return new T
            {
                Browser = browser,
                SearchLimitContainer = browser
            };
        }

        /// <summary>
        /// Creates a reference to an application from an existing process and returns a page of
        /// type <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">The type of the page to return.</typeparam>
        /// <param name="processToWrap">The process to create from</param>
        /// <returns>
        /// A page representing the launched application.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">processToWrap</exception>
        public static T FromProcess<T>(Process processToWrap) where T : Page, new()
        {
            if (processToWrap == null)
                throw new ArgumentNullException(nameof(processToWrap));

            var browserWindow = BrowserWindow.FromProcess(processToWrap);

            return new T
            {
                Browser = browserWindow,
                SearchLimitContainer = browserWindow
            };
        }
    }
}