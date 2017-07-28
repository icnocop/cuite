using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Lower Left Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject" />
    public class LowerLeftScreenObject : ScreenObject
    {
        /// <summary>
        /// Gets a value indicating whether the radio button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the radio button exists; otherwise, <c>false</c>.
        /// </value>
        public bool RadioButtonExists
        {
            get { return this.Window.Find<WinRadioButton>().Exists; }
        }

        private WinWindow Window
        {
            get
            {
                return this.Find<WinWindow>(By.ControlName("radioButtonLowerLeft"));
            }
        }
    }
}