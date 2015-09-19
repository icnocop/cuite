namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a Web browser dialog for Web page user interface (UI) testing.
    /// </summary>
    public class BrowserDialogUnderTest : BrowserWindowUnderTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserDialogUnderTest"/> class.
        /// </summary>
        public BrowserDialogUnderTest()
        {
            SearchProperties[PropertyNames.ClassName] = GetCurrentBrowser().DialogClassName;
            WindowTitles.Add(WindowTitle);
        }
    }
}