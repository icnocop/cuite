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
    public class CUITe_DynamicBrowserWindow : CUITe_BrowserWindow
    {
        public CUITe_DynamicBrowserWindow(string title)
            : base(title)
        {
            SetWindowTitle(title);
        }

        /// <summary>
        /// Gets the instance of T, which is an Object repository class (page definition).
        /// </summary>
        /// <typeparam name="T">Object repository class</typeparam>
        /// <returns>instance of T</returns>
        public static T GetBrowserWindow<T>(string title)
        {
            return (T)(object)ObjectRepositoryManager.GetInstance<T>(new object[]{title});
        }
    }
}
