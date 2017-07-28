using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Rebased Upper Left Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject{WpfGroup}" />
    public class RebasedUpperLeftScreenObject : ScreenObject<WpfGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedUpperLeftScreenObject"/> class.
        /// </summary>
        public RebasedUpperLeftScreenObject()
            : base(By.AutomationId("VHdOp0Tn4UyfmV6U91ZCIw"))
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
            get { return Find<WpfCheckBox>(By.AutomationId("Ax9iHEo2gk-ayRFljKt2sA")).Exists; }
        }
    }
}