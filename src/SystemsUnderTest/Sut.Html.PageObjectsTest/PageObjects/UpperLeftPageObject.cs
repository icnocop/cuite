using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Upper Left Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject" />
    public class UpperLeftPageObject : PageObject
    {
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