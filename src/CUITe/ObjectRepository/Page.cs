using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ObjectRepository
{
    /// <summary>
    /// Abstract class representing a page in a HTML application.
    /// </summary>
    public abstract class Page : PageComponent
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
    }
}