using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
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
            get { return Find<SilverlightCheckBox>(By.AutomationId("Pb67nqNzdkKZPTz-cUXtTQ")).Exists; }
        }
    }
}