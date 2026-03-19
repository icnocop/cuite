using System;
using System.Diagnostics;
using System.Windows.Automation;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Browsers
{
    /// <summary>
    /// Provides methods to launch a <see cref="BrowserWindow"/>, handling the case where
    /// Internet Explorer cannot be launched directly via <see cref="BrowserWindow.Launch(Uri)"/>
    /// on newer operating systems.
    /// </summary>
    public static class BrowserWindowLauncher
    {
        private const int NavigateNoReadFromCache = 0x4;

        /// <summary>
        /// Launches a browser window for the specified URL or file path.
        /// When the current browser is Internet Explorer, the COM automation approach is used
        /// because <see cref="BrowserWindow.Launch(Uri)"/> may fail on newer operating systems.
        /// For other browsers, delegates to <see cref="BrowserWindow.Launch(Uri)"/>.
        /// </summary>
        /// <param name="url">The URL or file path to navigate to.</param>
        /// <returns>A <see cref="BrowserWindow"/> representing the launched browser.</returns>
        public static BrowserWindow Launch(string url)
        {
            if (url == null)
                throw new ArgumentNullException("url");

            if (string.Equals(BrowserWindow.CurrentBrowser, InternetExplorer.Name, StringComparison.OrdinalIgnoreCase))
            {
                return LaunchInternetExplorer(new Uri(url));
            }

            return BrowserWindow.Launch(url);
        }

        /// <summary>
        /// Launches a browser window for the specified URI.
        /// When the current browser is Internet Explorer, the COM automation approach is used
        /// because <see cref="BrowserWindow.Launch(Uri)"/> may fail on newer operating systems.
        /// For other browsers, delegates to <see cref="BrowserWindow.Launch(Uri)"/>.
        /// </summary>
        /// <param name="uri">The URI to navigate to.</param>
        /// <returns>A <see cref="BrowserWindow"/> representing the launched browser.</returns>
        public static BrowserWindow Launch(Uri uri)
        {
            if (uri == null)
                throw new ArgumentNullException("uri");

            if (string.Equals(BrowserWindow.CurrentBrowser, InternetExplorer.Name, StringComparison.OrdinalIgnoreCase))
            {
                return LaunchInternetExplorer(uri);
            }

            return BrowserWindow.Launch(uri);
        }

        private static BrowserWindow LaunchInternetExplorer(Uri uri)
        {
            SHDocVw.InternetExplorer ie = (SHDocVw.InternetExplorer)Activator.CreateInstance(
                Type.GetTypeFromProgID("InternetExplorer.Application"));

            ie.Visible = true;

            ie.Navigate(uri.AbsoluteUri, NavigateNoReadFromCache);

            IntPtr windowHandle = new IntPtr(ie.HWND);
            AutomationElement windowElement = AutomationElement.FromHandle(windowHandle);
            windowElement.SetFocus();

            Process process = Process.GetProcessById(windowElement.Current.ProcessId);

            return BrowserWindow.FromProcess(process);
        }
    }
}
