using CUITe.PageObjects;

namespace Sut.HtmlTest.PageObjects
{
    /// <summary>
    /// HTML Test Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class HtmlTestPage : Page
    {
        /// <summary>
        /// Gets the div1.
        /// </summary>
        /// <value>
        /// The div1.
        /// </value>
        public Div1 Div1
        {
            get { return GetPageObject<Div1>(); }
        }
    }
}