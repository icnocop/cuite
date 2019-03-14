using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Rebased Upper Right Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject{WpfGroup}" />
    public class RebasedUpperRightScreenObject : ScreenObject<WpfGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedUpperRightScreenObject"/> class.
        /// </summary>
        public RebasedUpperRightScreenObject()
            : base(By.AutomationId("L9Z3HQOziUWAllix8yzsEg"))
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
            get { return Find<WpfCheckBox>(By.AutomationId("C_-kLEiiN0Odz20KncjQJQ")).Exists; }
        }
    }
}