using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Rebased Lower Right Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject{WpfGroup}" />
    public class RebasedLowerRightScreenObject : ScreenObject<WpfGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedLowerRightScreenObject"/> class.
        /// </summary>
        public RebasedLowerRightScreenObject()
            : base(By.AutomationId("4zQL8W23A0ODIzgYYhP4tA"))
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
            get { return Find<WpfRadioButton>(By.AutomationId("oEOhLBF5ske3yGfbHhThuA")).Exists; }
        }
    }
}