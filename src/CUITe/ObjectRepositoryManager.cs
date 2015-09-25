using System;
using CUITe.Controls.HtmlControls;
using CUITHtmlControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe
{
    internal class ObjectRepositoryManager
    {
        internal static T GetInstance<T>(params object[] args) where T : BrowserWindowUnderTest
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }
    }
}