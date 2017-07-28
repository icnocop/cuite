using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Upper Left Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject" />
    public class UpperLeftScreenObject : ScreenObject
    {
        /// <summary>
        /// Gets a value indicating whether the check box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the check box exists; otherwise, <c>false</c>.
        /// </value>
        public bool CheckBoxExists
        {
            get { return this.Window.Find<WinCheckBox>().Exists; }
        }

        private WinWindow Window
        {
            get
            {
                return this.Find<WinWindow>(By.ControlName("checkBoxUpperLeft"));
            }
        }
    }
}