using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.WorkflowsTest.ScreenObjects
{
    /// <summary>
    /// Finished Wizard Page
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
            get { return Find<WpfText>(By.AutomationId("VFLNy3N30EeNzd8og89CLQ")).Exists; }
        }
    }
}