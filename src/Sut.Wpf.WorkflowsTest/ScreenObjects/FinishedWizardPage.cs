using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.WorkflowsTest.ScreenObjects
{
    public class FinishedWizardPage : Screen
    {
        public bool CongratulationsExists
        {
            get { return Find<WpfText>(By.AutomationId("VFLNy3N30EeNzd8og89CLQ")).Exists; }
        }
    }
}