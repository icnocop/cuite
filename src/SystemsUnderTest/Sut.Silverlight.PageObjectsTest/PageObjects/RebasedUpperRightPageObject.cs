using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Rebased Upper Right Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{SilverlightTab}" />
    public class RebasedUpperRightPageObject : PageObject<SilverlightTab>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedUpperRightPageObject"/> class.
        /// </summary>
        public RebasedUpperRightPageObject()
            : base(By.AutomationId("sk0ELlIxRkSChVuWnKrEMw"))
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
            get { return Find<SilverlightCheckBox>(By.AutomationId("pxr987yTh0u0k72WGfOimw")).Exists; }
        }
    }
}