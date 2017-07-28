using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Rebased Lower Left Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{HtmlDiv}" />
    public class RebasedLowerLeftPageObject : PageObject<HtmlDiv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedLowerLeftPageObject"/> class.
        /// </summary>
        public RebasedLowerLeftPageObject()
            : base(By.Id("lowerdiv"))
        {
        }

        /// <summary>
        /// Gets a value indicating whether the radio button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [RadioButton exists]; otherwise, <c>false</c>.
        /// </value>
        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerleft")).Exists; }
        }
    }
}