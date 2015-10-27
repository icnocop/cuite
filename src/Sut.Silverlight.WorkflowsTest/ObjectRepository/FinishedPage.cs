using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.WorkflowsTest.ObjectRepository
{
    public class FinishedPage : Page
    {
        public bool CongratulationsExists
        {
            get { return Find<SilverlightText>(By.AutomationId("TDwIrgVYv0ynSwGOZ2kyww")).Exists; }
        }
    }
}