namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a Web browser window with a specific title for Web page user interface (UI)
    /// testing.
    /// </summary>
    public class DynamicBrowserWindowUnderTest : BrowserWindowUnderTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicBrowserWindowUnderTest"/> class.
        /// </summary>
        /// <param name="title">The window title.</param>
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
            return ObjectRepositoryManager.GetInstance<T>(title);
        }
    }
}