using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Upper Right Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject" />
    public class UpperRightPageObject : PageObject
    {
        /// <summary>
        /// Gets a value indicating whether the check box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the check box exists; otherwise, <c>false</c>.
        /// </value>
        public bool CheckBoxExists
        {
            get { return Find<SilverlightCheckBox>(By.AutomationId("pxr987yTh0u0k72WGfOimw")).Exists; }
        }
    }
}