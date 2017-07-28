using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Rebased Lower Left Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject{WpfGroup}" />
    public class RebasedLowerLeftScreenObject : ScreenObject<WpfGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RebasedLowerLeftScreenObject"/> class.
        /// </summary>
        public RebasedLowerLeftScreenObject()
            : base(By.AutomationId("fP30sIPPlUSqyjyzfMHKfQ"))
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
            get { return Find<WpfRadioButton>(By.AutomationId("U-nw96CGFUuMrbKg3h0tCQ")).Exists; }
        }
    }
}