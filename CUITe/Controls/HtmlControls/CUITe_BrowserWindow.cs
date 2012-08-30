using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using SHDocVw;
using mshtml;
using System.Reflection;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_BrowserWindow : BrowserWindow
    {
        public string sWindowTitle;
        private HtmlCustom mSlObjectContainer;

        public CUITe_BrowserWindow()
            : this(null)
        {
            
        }

        public CUITe_BrowserWindow(string title)
        {
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            SetWindowTitle(title);
        }

        /// <summary>
        /// Launches the specified url.
        /// </summary>
        /// <param name="url">The url.</param>
        /// <returns>The launched BrowserWindow</returns>
        public static new BrowserWindow Launch(string url)
        {
            return BrowserWindow.Launch(new Uri(url));
        }

        /// <summary>
        /// Launches the specified url.
        /// </summary>
        /// <param name="url">The url.</param>
        /// <param name="title">The title.</param>
        /// <returns>The CUITe_BrowserWindow that matches the title</returns>
        public static new CUITe_BrowserWindow Launch(string url, string title)
        {
            BrowserWindow.Launch(new Uri(url));
            return new CUITe_BrowserWindow(title);
        }

        /// <summary>
        /// Launches the specified url.
        /// </summary>
        /// <typeparam name="T">Object repository class</typeparam>
        /// <param name="url">The url.</param>
        /// <returns>An instance of the object repository class that matches the title</returns>
        public static T Launch<T>(string url)
            where T : CUITe_BrowserWindow
        {
            BrowserWindow.Launch(new Uri(url));
            return CUITe_BrowserWindow.GetBrowserWindow<T>();
        }

        /// <summary>
        /// Gets the instance of T, which is an Object repository class (page definition).
        /// </summary>
        /// <typeparam name="T">Object repository class</typeparam>
        /// <returns>instance of T</returns>
        public static T GetBrowserWindow<T>()
        {
            return (T)(object)ObjectRepositoryManager.GetInstance<T>();
        }

        public void SetWindowTitle(string title)
        {
            this.WindowTitles.Clear();
            this.WindowTitles.Add(title);
            this.sWindowTitle = title;
        }

        public new void WaitForControlReady()
        {
            GetBrowserWindow().WaitForControlReady();
        }

        public new void WaitForControlReady(int milliSecondsTimeOut)
        {
            GetBrowserWindow().WaitForControlReady(milliSecondsTimeOut);
        }

        /// <summary>
        /// Closes the CUITe_BrowserWindow instance.
        /// </summary>
        public new void Close()
        {
            BrowserWindow window = BrowserWindow.Locate(this.sWindowTitle);
            window.Close();
        }

        #region internal methods

        internal BrowserWindow GetBrowserWindow()
        {
            return BrowserWindow.Locate(this.sWindowTitle);
        }

        public HtmlCustom SlObjectContainer
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

        #endregion

        public void NavigateToUrl(string sUrl)
        {
            this.NavigateToUrl(new Uri(sUrl));
        }

        /// <summary>
        /// Closes all IE instances.
        /// </summary>
        public static void CloseAllBrowsers()
        {
            Process[] pro_list = Process.GetProcessesByName("iexplore");
            foreach (Process pro in pro_list)
            {
                pro.Kill(); // Kill All Open IE's
            }
        }

        /// <summary>
        /// Run/evaluate JavaScript code in the DOM context.
        /// </summary>
        /// <param name="sCode">JavaScript code as string</param>
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

        public static void Authenticate(string sUserName, string sPassword)
        {
            UIWindowsSecurityWindow winTemp2 = new CUITe.Controls.UIWindowsSecurityWindow();
            if (winTemp2.UIUseAnotherAccountText.Exists)
            {
                Mouse.Click(winTemp2.UIUseAnotherAccountText);
            }
            winTemp2.UIUsernameEdit.Text = sUserName;
            winTemp2.UIPasswordEdit.Text = sPassword;
            Mouse.Click(winTemp2.UIOKButton);
        }

        #region Objects initialized at runtime without ObjectRepository entries

        /// <summary>
        /// Gets the CUITe control object when search parameters are passed. 
        /// You don't have to create the object repository entry for this.
        /// </summary>
        /// <typeparam name="T">Pass the CUITe control you are looking for.</typeparam>
        /// <param name="searchParameters">In 'Key1=Value1;Key2=Value2' format. For example 'Id=firstname'</param>
        /// <returns>CUITe_* control object</returns>
        public T Get<T>(string searchParameters = null)
            where T : ICUITe_ControlBase
        {
            T control = CUITe_ControlBaseFactory.Create<T>(searchParameters);

            if (typeof(T).Namespace.Equals("CUITe.Controls.SilverlightControls"))
            {
                var baseControl = Activator.CreateInstance(control.GetBaseType(), new object[] { this.SlObjectContainer });
                control.Wrap(baseControl);
            }
            else
            {
                var baseControl = Activator.CreateInstance(control.GetBaseType(), new object[] { this });
                control.Wrap(baseControl);
            }

            return control;
        }

        [Obsolete("GetHtmlButton(string) is deprecated, please use Get<CUITe_HtmlButton>(string) instead.")]
        public CUITe_HtmlButton GetHtmlButton(string searchParameters)
        {
            CUITe_HtmlButton button = new CUITe_HtmlButton(searchParameters);
            button.Wrap(new HtmlButton(this));
            return button;
        }

        [Obsolete("GetHtmlCell(string) is deprecated, please use Get<CUITe_HtmlCell>(string) instead.")]
        public CUITe_HtmlCell GetHtmlCell(string searchParameters)
        {
            CUITe_HtmlCell cell = new CUITe_HtmlCell(searchParameters);
            cell.Wrap(new HtmlCell(this));
            return cell;
        }

        [Obsolete("GetHtmlCheckBox(string) is deprecated, please use Get<CUITe_HtmlCheckBox>(string) instead.")]
        public CUITe_HtmlCheckBox GetHtmlCheckBox(string searchParameters)
        {
            CUITe_HtmlCheckBox chk = new CUITe_HtmlCheckBox(searchParameters);
            chk.Wrap(new HtmlCheckBox(this));
            return chk;
        }

        [Obsolete("GetHtmlComboBox(string) is deprecated, please use Get<CUITe_HtmlComboBox>(string) instead.")]
        public CUITe_HtmlComboBox GetHtmlComboBox(string searchParameters)
        {
            CUITe_HtmlComboBox cmb = new CUITe_HtmlComboBox(searchParameters);
            cmb.Wrap(new HtmlComboBox(this));
            return cmb;
        }

        [Obsolete("GetHtmlDiv(string) is deprecated, please use Get<CUITe_HtmlDiv>(string) instead.")]
        public CUITe_HtmlDiv GetHtmlDiv(string searchParameters)
        {
            CUITe_HtmlDiv div = new CUITe_HtmlDiv(searchParameters);
            div.Wrap(new HtmlDiv(this));
            return div;
        }

        [Obsolete("GetHtmlEdit(string) is deprecated, please use Get<CUITe_HtmlEdit>(string) instead.")]
        public CUITe_HtmlEdit GetHtmlEdit(string searchParameters)
        {
            CUITe_HtmlEdit edit = new CUITe_HtmlEdit(searchParameters);
            edit.Wrap(new HtmlEdit(this));
            return edit;
        }

        [Obsolete("GetHtmlFileInput(string) is deprecated, please use Get<CUITe_HtmlFileInput>(string) instead.")]
        public CUITe_HtmlFileInput GetHtmlFileInput(string searchParameters)
        {
            CUITe_HtmlFileInput fin = new CUITe_HtmlFileInput(searchParameters);
            fin.Wrap(new HtmlFileInput(this));
            return fin;
        }

        [Obsolete("GetHtmlHyperlink(string) is deprecated, please use Get<CUITe_HtmlHyperlink>(string) instead.")]
        public CUITe_HtmlHyperlink GetHtmlHyperlink(string searchParameters)
        {
            CUITe_HtmlHyperlink href = new CUITe_HtmlHyperlink(searchParameters);
            href.Wrap(new HtmlHyperlink(this));
            return href;
        }

        [Obsolete("GetHtmlImage(string) is deprecated, please use Get<CUITe_HtmlImage>(string) instead.")]
        public CUITe_HtmlImage GetHtmlImage(string searchParameters)
        {
            CUITe_HtmlImage img = new CUITe_HtmlImage(searchParameters);
            img.Wrap(new HtmlImage(this));
            return img;
        }

        [Obsolete("GetHtmlInputButton(string) is deprecated, please use Get<CUITe_HtmlInputButton>(string) instead.")]
        public CUITe_HtmlInputButton GetHtmlInputButton(string searchParameters)
        {
            CUITe_HtmlInputButton input = new CUITe_HtmlInputButton(searchParameters);
            input.Wrap(new HtmlInputButton(this));
            return input;
        }

        [Obsolete("GetHtmlLabel(string) is deprecated, please use Get<CUITe_HtmlLabel>(string) instead.")]
        public CUITe_HtmlLabel GetHtmlLabel(string searchParameters)
        {
            CUITe_HtmlLabel lbl = new CUITe_HtmlLabel(searchParameters);
            lbl.Wrap(new HtmlLabel(this));
            return lbl;
        }

        [Obsolete("GetHtmlList(string) is deprecated, please use Get<CUITe_HtmlList>(string) instead.")]
        public CUITe_HtmlList GetHtmlList(string searchParameters)
        {
            CUITe_HtmlList lst = new CUITe_HtmlList(searchParameters);
            lst.Wrap(new HtmlList(this));
            return lst;
        }

        [Obsolete("GetHtmlPassword(string) is deprecated, please use Get<CUITe_HtmlPassword>(string) instead.")]
        public CUITe_HtmlPassword GetHtmlPassword(string searchParameters)
        {
            CUITe_HtmlPassword pwd = new CUITe_HtmlPassword(searchParameters);
            HtmlEdit tmp = new HtmlEdit(this);
            tmp.FilterProperties[HtmlEdit.PropertyNames.Type] = "PASSWORD";
            pwd.Wrap(tmp);
            return pwd;
        }

        [Obsolete("GetHtmlRadioButton(string) is deprecated, please use Get<CUITe_HtmlRadioButton>(string) instead.")]
        public CUITe_HtmlRadioButton GetHtmlRadioButton(string searchParameters)
        {
            CUITe_HtmlRadioButton rad = new CUITe_HtmlRadioButton(searchParameters);
            rad.Wrap(new HtmlRadioButton(this));
            return rad;
        }

        [Obsolete("GetHtmlSpan(string) is deprecated, please use Get<CUITe_HtmlSpan>(string) instead.")]
        public CUITe_HtmlSpan GetHtmlSpan(string searchParameters)
        {
            CUITe_HtmlSpan span = new CUITe_HtmlSpan(searchParameters);
            span.Wrap(new HtmlSpan(this));
            return span;
        }

        [Obsolete("GetHtmlTable(string) is deprecated, please use Get<CUITe_HtmlTable>(string) instead.")]
        public CUITe_HtmlTable GetHtmlTable(string searchParameters)
        {
            CUITe_HtmlTable tbl = new CUITe_HtmlTable(searchParameters);
            tbl.Wrap(new HtmlTable(this));
            return tbl;
        }

        [Obsolete("GetHtmlTextArea(string) is deprecated, please use Get<CUITe_HtmlTextArea>(string) instead.")]
        public CUITe_HtmlTextArea GetHtmlTextArea(string searchParameters)
        {
            CUITe_HtmlTextArea tarea = new CUITe_HtmlTextArea(searchParameters);
            tarea.Wrap(new HtmlTextArea(this));
            return tarea;
        }

        #endregion
    }
}
