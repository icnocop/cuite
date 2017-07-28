using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Rebased Lower Right Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{HtmlDiv}" />
    public class RebasedLowerRightPageObject : PageObject<HtmlDiv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedLowerRightPageObject"/> class.
        /// </summary>
        public RebasedLowerRightPageObject()
            : base(By.Id("lowerdiv"))
        {
        }

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