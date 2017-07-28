using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Upper Right Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject" />
    public class UpperRightScreenObject : ScreenObject
    {
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