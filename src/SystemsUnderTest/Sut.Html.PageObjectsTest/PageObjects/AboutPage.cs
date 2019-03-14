using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// About Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class AboutPage : Page
    {
        /// <summary>
        /// Gets a value indicating whether the framework message exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the framework message exists; otherwise, <c>false</c>.
        /// </value>
        public bool FrameworkMessageExists
        {
            get { return Find<HtmlParagraph>(By.Id("framework")).Exists; }
        }
    }
}