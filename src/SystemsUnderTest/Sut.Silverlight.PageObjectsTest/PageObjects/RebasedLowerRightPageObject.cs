using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Rebased Lower Right Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{SilverlightTab}" />
    public class RebasedLowerRightPageObject : PageObject<SilverlightTab>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedLowerRightPageObject"/> class.
        /// </summary>
        public RebasedLowerRightPageObject()
            : base(By.AutomationId("vzoWE0pag0S7yk0Wmb9iug"))
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
            get { return Find<SilverlightRadioButton>(By.AutomationId("0IZpFrh750Kps3zMlrFFcA")).Exists; }
        }
    }
}