using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.WorkflowsTest.PageObjects
{
    /// <summary>
    /// Finished Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class FinishedPage : Page
    {
        /// <summary>
        /// Gets a value indicating whether the congratulations paragraph exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the congratulations paragraph exists; otherwise, <c>false</c>.
        /// </value>
        public bool CongratulationsExists
        {
            get { return Find<HtmlParagraph>(By.Id("congratulations")).Exists; }
        }
    }
}