using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ObjectRepository
{
    public class FinishedWizardPage : Screen
    {
        public bool CongratulationsExists
        {
            get { return Find<WinText>(By.ControlName("labelCongratulations")).Exists; }
        }
    }
}