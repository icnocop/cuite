using Microsoft.VisualStudio.TestTools.UITesting;
using SHDocVw;

namespace CUITe.Browsers
{
    public class InternetExplorer : Browser, IBrowser
    {
        public static string Name = "ie";
        
        public InternetExplorer()
            : base(Name, "iexplore", "IEFrame", "Internet Explorer_TridentDlgFrame")
        {
        }

        /// <summary>
        /// Run/evaluate JavaScript code in the DOM context.
        /// </summary>
        /// <param name="browserWindow">The browser window.</param>
        /// <param name="code">The JavaScript code</param>
        public static void RunScript(BrowserWindow browserWindow, string code)
        {
            SHDocVw.InternetExplorer internetExplorer = null;
            ShellWindows shellWindows = new ShellWindows();
            foreach (SHDocVw.InternetExplorer shellWindow in shellWindows)
            {
                if (shellWindow.HWND == browserWindow.WindowHandle.ToInt32())
                {
                    internetExplorer = shellWindow;
                    break;
                }
            }
            internetExplorer.Document.parentWindow.execScript(code);
        }
    }
}
