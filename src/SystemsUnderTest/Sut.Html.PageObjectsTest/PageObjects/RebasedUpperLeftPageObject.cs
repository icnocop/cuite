using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Rebased Upper Left Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{HtmlDiv}" />
    public class RebasedUpperLeftPageObject : PageObject<HtmlDiv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedUpperLeftPageObject"/> class.
        /// </summary>
        public RebasedUpperLeftPageObject()
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
            get { return Find<HtmlCheckBox>(By.Id("upperleft")).Exists; }
        }
    }
}