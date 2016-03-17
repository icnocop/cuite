using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CUITe.Browsers;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a Web browser window for Web page user interface (UI) testing.
    /// </summary>
    public class BrowserWindowUnderTest : BrowserWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserWindowUnderTest"/> class.
        /// </summary>
        public BrowserWindowUnderTest()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserWindowUnderTest"/> class.
        /// </summary>
        /// <param name="title">The window title.</param>
        public BrowserWindowUnderTest(string title)
        {
            SearchProperties[PropertyNames.ClassName] = GetCurrentBrowser().WindowClassName;

            SetWindowTitle(title);
        }

        /// <summary>
        /// Gets the window title.
        /// </summary>
        public string WindowTitle { get; private set; }

        /// <summary>
        /// Gets the current browser.
        /// </summary>
        /// <returns></returns>
        public static IBrowser GetCurrentBrowser()
        {
            var ie = new InternetExplorer();
            string currentBrowserName = CurrentBrowser;

            if (currentBrowserName == null)
            {
                // Default browser
                return ie;
            }

            var supportedBrowsers = new List<IBrowser>
            {
                ie,
                new Firefox(),
                new Chrome()
            };

            IBrowser currentBrowser = supportedBrowsers.SingleOrDefault(x => currentBrowserName.StartsWith(x.Name, StringComparison.OrdinalIgnoreCase));

            if (currentBrowser == null)
            {
                // Default browser
                return ie;
            }

            currentBrowser.Name = currentBrowserName;

            return currentBrowser;
        }

        /// <summary>
        /// Launches the specified URL.
        /// </summary>
        /// <typeparam name="T">The page object type.</typeparam>
        /// <param name="url">The URL.</param>
        public static T Launch<T>(string url) where T : BrowserWindowUnderTest, new()
        {
            var browserWindow = new T();
            browserWindow.CopyFrom(Launch(new Uri(url)));

            return browserWindow;
        }

        /// <summary>
        /// Gets the instance of T, which is an object repository class (page definition).
        /// </summary>
        /// <typeparam name="T">Object repository class</typeparam>
        /// <returns>instance of T</returns>
        public static T GetBrowserWindow<T>(string title = null) where T : BrowserWindowUnderTest
        {
            return (T)Activator.CreateInstance(typeof(T), title);
        }

        /// <summary>
        /// Sets the window title.
        /// </summary>
        /// <param name="title">The title.</param>
        public void SetWindowTitle(string title)
        {
            WindowTitles.Clear();
            WindowTitles.Add(title);
            WindowTitle = title;
        }

        /// <summary>
        /// Navigates to the specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        public void NavigateToUrl(string url)
        {
            NavigateToUrl(new Uri(url));
        }

        /// <summary>
        /// Closes all instances of the current browser.
        /// </summary>
        public static void CloseAllBrowsers()
        {
            // Kill all open browsers
            foreach (Process process in Process.GetProcessesByName(GetCurrentBrowser().ProcessName))
            {
                process.Kill();
            }
        }

        /// <summary>
        /// Authenticates the user with the specified user name and password.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        public static void Authenticate(string userName, string password)
        {
            var winTemp2 = new UIWindowsSecurityWindow();
            if (winTemp2.UIUseAnotherAccountText.Exists)
            {
                Mouse.Click(winTemp2.UIUseAnotherAccountText);
            }
            winTemp2.UIUsernameEdit.Text = userName;
            winTemp2.UIPasswordEdit.Text = password;
            Mouse.Click(winTemp2.UIOKButton);
        }
    }
}