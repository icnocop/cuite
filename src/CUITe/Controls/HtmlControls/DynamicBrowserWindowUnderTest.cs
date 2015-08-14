namespace CUITe.Controls.HtmlControls
{
    public class DynamicBrowserWindowUnderTest : BrowserWindowUnderTest
    {
        public DynamicBrowserWindowUnderTest(string title)
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
            return (T)ObjectRepositoryManager.GetInstance<T>(title);
        }
    }
}
