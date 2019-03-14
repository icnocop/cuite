using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Dialog Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class DialogPage : Page
    {
        /// <summary>
        /// Gets a value indicating whether the close button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the close button exists; otherwise, <c>false</c>.
        /// </value>
        public bool CloseButtonExists
        {
            get { return Find<SilverlightButton>(By.AutomationId("M20jNVw1-U68UocgbPyajw")).Exists; }
        }
    }
}