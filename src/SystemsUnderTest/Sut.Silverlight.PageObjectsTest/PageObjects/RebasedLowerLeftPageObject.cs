using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Rebased Lower Left Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{SilverlightTab}" />
    public class RebasedLowerLeftPageObject : PageObject<SilverlightTab>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedLowerLeftPageObject"/> class.
        /// </summary>
        public RebasedLowerLeftPageObject()
            : base(By.AutomationId("6B4YMUMZz0CAxPbskr1MgQ"))
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
            get { return Find<SilverlightRadioButton>(By.AutomationId("R96eNzWZrUeCOUOiCb5qEQ")).Exists; }
        }
    }
}