using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    /// <summary>
    /// Test HTML Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class TestHtmlPage : Page
    {
        /// <summary>
        /// Gets the paragraph.
        /// </summary>
        /// <value>
        /// The paragraph.
        /// </value>
        public HtmlParagraph Paragraph
        {
            get { return Find<HtmlParagraph>(By.Id("para1")); }
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <value>
        /// The list.
        /// </value>
        public HtmlUnorderedList List
        {
            get { return Find<HtmlUnorderedList>(By.Id("unorderedList")); }
        }

        /// <summary>
        /// Gets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public HtmlDocument Document
        {
            get { return Find<HtmlDocument>(); }
        }
    }
}