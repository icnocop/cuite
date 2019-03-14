using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Rebased Upper Right Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject{WinWindow}" />
    public class RebasedUpperRightScreenObject : ScreenObject<WinWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedUpperRightScreenObject"/> class.
        /// </summary>
        public RebasedUpperRightScreenObject()
            : base(By.ControlName("groupBoxUpperRight"))
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
            get { return Find<WinWindow>(By.ControlName("checkBoxUpperRight")).Find<WinCheckBox>().Exists; }
        }
    }
}