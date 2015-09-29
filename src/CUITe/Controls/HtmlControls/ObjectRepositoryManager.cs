using System;

namespace CUITe.Controls.HtmlControls
{
    internal class ObjectRepositoryManager
    {
        internal static T GetInstance<T>(params object[] args) where T : BrowserWindowUnderTest
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }
    }
}