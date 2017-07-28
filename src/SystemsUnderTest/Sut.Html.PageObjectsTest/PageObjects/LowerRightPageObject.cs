using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Lower Right Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject" />
    public class LowerRightPageObject : PageObject
    {
        /// <summary>
        /// Gets a value indicating whether the radio button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the radio button exists; otherwise, <c>false</c>.
        /// </value>
        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerright")).Exists; }
        }
    }
}