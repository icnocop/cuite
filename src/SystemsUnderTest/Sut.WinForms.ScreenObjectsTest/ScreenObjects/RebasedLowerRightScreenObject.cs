using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Rebased Lower Right Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject{WinWindow}" />
    public class RebasedLowerRightScreenObject : ScreenObject<WinWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedLowerRightScreenObject"/> class.
        /// </summary>
        public RebasedLowerRightScreenObject()
            : base(By.ControlName("groupBoxLowerRight"))
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
            get { return Find<WinWindow>(By.ControlName("radioButtonLowerRight")).Find<WinRadioButton>().Exists; }
        }
    }
}