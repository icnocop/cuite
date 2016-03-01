using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.WorkflowsTest.PageObjects
{
    public class FinishedPage : Page
    {
        public bool CongratulationsExists
        {
            get { return Find<SilverlightText>(By.AutomationId("TDwIrgVYv0ynSwGOZ2kyww")).Exists; }
        }
    }
}