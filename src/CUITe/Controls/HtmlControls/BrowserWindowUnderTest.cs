using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CUITe.Browsers;
using CUITe.Controls.TelerikControls;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// The browser window
    /// </summary>
    public class BrowserWindowUnderTest : BrowserWindow
    {
        public string sWindowTitle;
        private CUITControls.HtmlCustom mSlObjectContainer;

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
        /// <param name="title">The title.</param>
        public BrowserWindowUnderTest(string title)
        {
            SearchProperties[PropertyNames.ClassName] = GetCurrentBrowser().WindowClassName;

            SetWindowTitle(title);
        }

        /// <summary>
        /// Gets the current browser.
        /// </summary>
        /// <returns></returns>
        public static IBrowser GetCurrentBrowser()
        {
            InternetExplorer ie = new InternetExplorer();

            string currentBrowserName = CurrentBrowser;

            if (currentBrowserName == null)
            {
                //default browser
                return ie;
            }

            List<IBrowser> supportedBrowsers = new List<IBrowser>
            {
                ie,
                new Firefox(),
                new Chrome()
            };

            IBrowser currentBrowser = supportedBrowsers.SingleOrDefault(x => currentBrowserName.StartsWith(x.Name, StringComparison.OrdinalIgnoreCase));

            if (currentBrowser == null)
            {
                //default browser
                return ie;
            }

            currentBrowser.Name = currentBrowserName;

            return currentBrowser;
        }

        /// <summary>
        /// Launches the specified url.
        /// </summary>
        /// <param name="url">The url.</param>
        /// <returns>The launched BrowserWindow</returns>
        public new static BrowserWindow Launch(string url)
        {
            return Launch(new Uri(url));
        }

        /// <summary>
        /// Launches the specified url.
        /// </summary>
        /// <param name="url">The url.</param>
        /// <param name="title">The title.</param>
        /// <returns>The BrowserWindowUnderTest that matches the title</returns>
        public new static BrowserWindowUnderTest Launch(string url, string title)
        {
            var browserWindowUnderTest = new BrowserWindowUnderTest();
            browserWindowUnderTest.CopyFrom(Launch(new Uri(url)));

            return browserWindowUnderTest;
        }

        /// <summary>
        /// Launches the specified url.
        /// </summary>
        /// <typeparam name="T">Object repository class</typeparam>
        /// <param name="url">The url.</param>
        /// <returns>An instance of the object repository class that matches the title</returns>
        public static T Launch<T>(string url)
            where T : BrowserWindowUnderTest, new()
        {
            T browserWindow = new T();
            browserWindow.CopyFrom(Launch(new Uri(url)));

            return browserWindow;
        }

        /// <summary>
        /// Gets the instance of T, which is an Object repository class (page definition).
        /// </summary>
        /// <typeparam name="T">Object repository class</typeparam>
        /// <returns>instance of T</returns>
        public static T GetBrowserWindow<T>()
        {
            return ObjectRepositoryManager.GetInstance<T>();
        }

        /// <summary>
        /// Sets the window title.
        /// </summary>
        /// <param name="title">The title.</param>
        public void SetWindowTitle(string title)
        {
            WindowTitles.Clear();
            WindowTitles.Add(title);
            sWindowTitle = title;
        }

        public CUITControls.HtmlCustom SlObjectContainer
        {
            get
            {
                if ((mSlObjectContainer == null))
                {
                    mSlObjectContainer = new CUITControls.HtmlCustom(this);
                    mSlObjectContainer.SearchProperties["TagName"] = "OBJECT";
                    mSlObjectContainer.WindowTitles.Add(sWindowTitle);
                }
                return mSlObjectContainer;
            }
        }

        /// <summary>
        /// Navigates to the specified URL.
        /// </summary>
        /// <param name="sUrl">The s URL.</param>
        public void NavigateToUrl(string sUrl)
        {
            NavigateToUrl(new Uri(sUrl));
        }

        /// <summary>
        /// Closes all instances of the current browser.
        /// </summary>
        public static void CloseAllBrowsers()
        {
            Process[] pro_list = Process.GetProcessesByName(GetCurrentBrowser().ProcessName);
            foreach (Process pro in pro_list)
            {
                //kill all open browsers
                pro.Kill();
            }
        }

        /// <summary>
        /// Run/evaluate JavaScript code in the DOM context.
        /// </summary>
        /// <param name="code">The JavaScript code</param>
        public void RunScript(string code)
        {
            InternetExplorer.RunScript(this, code);
        }

        /// <summary>
        /// Authenticates the user with the specified user name and password.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        public static void Authenticate(string userName, string password)
        {
            UIWindowsSecurityWindow winTemp2 = new UIWindowsSecurityWindow();
            if (winTemp2.UIUseAnotherAccountText.Exists)
            {
                Mouse.Click(winTemp2.UIUseAnotherAccountText);
            }
            winTemp2.UIUsernameEdit.Text = userName;
            winTemp2.UIPasswordEdit.Text = password;
            Mouse.Click(winTemp2.UIOKButton);
        }

        #region Objects initialized at runtime without ObjectRepository entries

        /// <summary>
        /// Gets the CUITe control object when search parameters are passed. 
        /// You don't have to create the object repository entry for this.
        /// </summary>
        /// <typeparam name="T">Pass the CUITe control you are looking for.</typeparam>
        /// <param name="searchProperties">In 'Key1=Value1;Key2=Value2' format. For example 'Id=firstname'</param>
        /// <returns>CUITe control object</returns>
        public T Get<T>(string searchProperties = null) where T : ControlBase
        {
            T control = ControlBaseFactory.Create<T>(searchProperties);

            if (typeof(T).Namespace.Equals("CUITe.Controls.SilverlightControls"))
            {
                control.SourceControl.Container = SlObjectContainer;
            }
            else if (typeof(T).Namespace.Equals("CUITe.Controls.TelerikControls"))
            {
                (control as ComboBox).SetWindow(this);
            }
            else
            {
                control.SourceControl.Container = this;
            }

            return control;
        }

        #endregion
    }
}