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
        {
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add(this.sWindowTitle);
        }

        public CUITe_BrowserWindow(string sTitle)
        {
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add(sTitle);
            this.sWindowTitle = sTitle;
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

        #region Objects initialized at runtime without ObjectRepository entries

        public CUITe_HtmlButton GetHtmlButton(string sSearchParameters)
        {
            CUITe_HtmlButton button = new CUITe_HtmlButton(sSearchParameters);
            button.Wrap(new HtmlButton(this));
            return button;
        }

        public CUITe_HtmlCell GetHtmlCell(string sSearchParameters)
        {
            CUITe_HtmlCell cell = new CUITe_HtmlCell(sSearchParameters);
            cell.Wrap(new HtmlCell(this));
            return cell;
        }

        public CUITe_HtmlCheckBox GetHtmlCheckBox(string sSearchParameters)
        {
            CUITe_HtmlCheckBox chk = new CUITe_HtmlCheckBox(sSearchParameters);
            chk.Wrap(new HtmlCheckBox(this));
            return chk;
        }

        public CUITe_HtmlComboBox GetHtmlComboBox(string sSearchParameters)
        {
            CUITe_HtmlComboBox cmb = new CUITe_HtmlComboBox(sSearchParameters);
            cmb.Wrap(new HtmlComboBox(this));
            return cmb;
        }

        public CUITe_HtmlDiv GetHtmlDiv(string sSearchParameters)
        {
            CUITe_HtmlDiv div = new CUITe_HtmlDiv(sSearchParameters);
            div.Wrap(new HtmlDiv(this));
            return div;
        }

        public CUITe_HtmlEdit GetHtmlEdit(string sSearchParameters)
        {
            CUITe_HtmlEdit edit = new CUITe_HtmlEdit(sSearchParameters);
            edit.Wrap(new HtmlEdit(this));
            return edit;
        }

        public CUITe_HtmlFileInput GetHtmlFileInput(string sSearchParameters)
        {
            CUITe_HtmlFileInput fin = new CUITe_HtmlFileInput(sSearchParameters);
            fin.Wrap(new HtmlFileInput(this));
            return fin;
        }

        public CUITe_HtmlHyperlink GetHtmlHyperlink(string sSearchParameters)
        {
            CUITe_HtmlHyperlink href = new CUITe_HtmlHyperlink(sSearchParameters);
            href.Wrap(new HtmlHyperlink(this));
            return href;
        }

        public CUITe_HtmlImage GetHtmlImage(string sSearchParameters)
        {
            CUITe_HtmlImage img = new CUITe_HtmlImage(sSearchParameters);
            img.Wrap(new HtmlImage(this));
            return img;
        }

        public CUITe_HtmlInputButton GetHtmlInputButton(string sSearchParameters)
        {
            CUITe_HtmlInputButton input = new CUITe_HtmlInputButton(sSearchParameters);
            input.Wrap(new HtmlInputButton(this));
            return input;
        }

        public CUITe_HtmlLabel GetHtmlLabel(string sSearchParameters)
        {
            CUITe_HtmlLabel lbl = new CUITe_HtmlLabel(sSearchParameters);
            lbl.Wrap(new HtmlLabel(this));
            return lbl;
        }

        public CUITe_HtmlList GetHtmlList(string sSearchParameters)
        {
            CUITe_HtmlList lst = new CUITe_HtmlList(sSearchParameters);
            lst.Wrap(new HtmlList(this));
            return lst;
        }

        public CUITe_HtmlPassword GetHtmlPassword(string sSearchParameters)
        {
            CUITe_HtmlPassword pwd = new CUITe_HtmlPassword(sSearchParameters);
            HtmlEdit tmp = new HtmlEdit(this);
            tmp.FilterProperties[HtmlEdit.PropertyNames.Type] = "PASSWORD";
            pwd.Wrap(tmp);
            return pwd;
        }

        public CUITe_HtmlRadioButton GetHtmlRadioButton(string sSearchParameters)
        {
            CUITe_HtmlRadioButton rad = new CUITe_HtmlRadioButton(sSearchParameters);
            rad.Wrap(new HtmlRadioButton(this));
            return rad;
        }

        public CUITe_HtmlSpan GetHtmlSpan(string sSearchParameters)
        {
            CUITe_HtmlSpan span = new CUITe_HtmlSpan(sSearchParameters);
            span.Wrap(new HtmlSpan(this));
            return span;
        }

        public CUITe_HtmlTable GetHtmlTable(string sSearchParameters)
        {
            CUITe_HtmlTable tbl = new CUITe_HtmlTable(sSearchParameters);
            tbl.Wrap(new HtmlTable(this));
            return tbl;
        }

        public CUITe_HtmlTextArea GetHtmlTextArea(string sSearchParameters)
        {
            CUITe_HtmlTextArea tarea = new CUITe_HtmlTextArea(sSearchParameters);
            tarea.Wrap(new HtmlTextArea(this));
            return tarea;
        }

        #endregion
    }
}
