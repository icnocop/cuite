using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ScreenObjects
{
    public class FinishedWizardPage : Screen
    {
        public bool CongratulationsExists
        {
            get { return Find<WinText>(By.ControlName("labelCongratulations")).Exists; }
        }
    }
}