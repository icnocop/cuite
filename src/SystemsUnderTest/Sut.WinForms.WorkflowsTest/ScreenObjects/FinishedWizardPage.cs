using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ScreenObjects
{
    /// <summary>
    /// Finish Wizard Page
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class FinishedWizardPage : Screen
    {
        /// <summary>
        /// Gets a value indicating whether the congratulations text exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the congratulations text exists; otherwise, <c>false</c>.
        /// </value>
        public bool CongratulationsExists
        {
            get { return Find<WinWindow>(By.ControlName("labelCongratulations")).Find<WinText>().Exists; }
        }
    }
}