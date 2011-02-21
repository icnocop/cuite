using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using SHDocVw;
using mshtml;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_BrowserWindow : BrowserWindow
    {
        public string sWindowTitle;
        private HtmlCustom mSlObjectContainer;

        public CUITe_BrowserWindow() 
        {
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add(this.sWindowTitle);
        }

        internal void SetWidowTitle(string sWindowTitle) 
        {
            this.sWindowTitle = sWindowTitle;
        }

        public static new void Launch(string sURL)
        {
            BrowserWindow.Launch(new Uri(sURL));
        }

        public static T GetBrowserWindow<T>()
        {
            return (T)(object)ObjectRepositoryManager.GetInstance<T>();
        }

        public new void WaitForControlReady()
        {
            GetBrowserWindow().WaitForControlReady();
        }

        public new void WaitForControlReady(int milliSecondsTimeOut)
        {
            GetBrowserWindow().WaitForControlReady(milliSecondsTimeOut);
        }

        public new void Close()
        {
            BrowserWindow window = BrowserWindow.Locate(this.sWindowTitle);
            window.Close();
        }

        internal BrowserWindow GetBrowserWindow()
        {
            return BrowserWindow.Locate(this.sWindowTitle);
        }

        public void NavigateToUrl(string sUrl)
        {
            this.NavigateToUrl(new Uri(sUrl));
        }

        public static void CloseAllBrowsers()
        {
            Process[] pro_list = Process.GetProcessesByName("iexplore");
            foreach (Process pro in pro_list)
            {
                pro.Kill(); // Kill All Open IE's
            }
        }

        public void RunScript(string sCode)
        {
            InternetExplorer IE = null;
            ShellWindows shws = new ShellWindows();
            foreach(InternetExplorer shwin in shws) 
            {
                if (shwin.HWND == GetBrowserWindow().WindowHandle.ToInt32())
                {
                    IE = shwin;
                    break;
                }
            }
            IE.Document.parentWindow.execScript(sCode);
        }

        internal HtmlCustom SlObjectContainer
        {
            get
            {
                if ((this.mSlObjectContainer == null))
                {
                    this.mSlObjectContainer = new HtmlCustom(this);
                    this.mSlObjectContainer.SearchProperties["TagName"] = "OBJECT";
                    this.mSlObjectContainer.WindowTitles.Add(this.sWindowTitle);
                }
                return this.mSlObjectContainer;
            }
        }
    }
}
