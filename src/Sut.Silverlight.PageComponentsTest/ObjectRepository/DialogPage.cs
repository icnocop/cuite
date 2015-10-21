using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.ObjectRepository
{
    public class DialogPage : Page
    {
        public bool CloseButtonExists
        {
            get { return Find<SilverlightButton>(By.AutomationId("M20jNVw1-U68UocgbPyajw")).Exists; }
        }
    }
}