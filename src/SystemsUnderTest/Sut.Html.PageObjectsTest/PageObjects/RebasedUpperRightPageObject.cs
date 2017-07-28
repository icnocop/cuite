using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Rebased Upper Right Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{HtmlDiv}" />
    public class RebasedUpperRightPageObject : PageObject<HtmlDiv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedUpperRightPageObject"/> class.
        /// </summary>
        public RebasedUpperRightPageObject()
            : base(By.Id("upperdiv"))
        {
        }

        /// <summary>
        /// Gets a value indicating whether the check box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the check box exists; otherwise, <c>false</c>.
        /// </value>
        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperright")).Exists; }
        }
    }
}