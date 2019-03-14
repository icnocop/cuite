using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Rebased Upper Left Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject{WinWindow}" />
    public class RebasedUpperLeftScreenObject : ScreenObject<WinWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedUpperLeftScreenObject"/> class.
        /// </summary>
        public RebasedUpperLeftScreenObject()
            : base(By.ControlName("groupBoxUpperLeft"))
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
            get { return Find<WinWindow>(By.ControlName("checkBoxUpperLeft")).Find<WinCheckBox>().Exists; }
        }
    }
}