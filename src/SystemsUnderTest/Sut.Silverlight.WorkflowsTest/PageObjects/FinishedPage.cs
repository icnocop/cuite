using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.WorkflowsTest.PageObjects
{
    /// <summary>
    /// Finished Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class FinishedPage : Page
    {
        /// <summary>
        /// Gets a value indicating whether the congratulations text exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the congratulations text exists; otherwise, <c>false</c>.
        /// </value>
        public bool CongratulationsExists
        {
            get { return Find<SilverlightText>(By.AutomationId("TDwIrgVYv0ynSwGOZ2kyww")).Exists; }
        }
    }
}