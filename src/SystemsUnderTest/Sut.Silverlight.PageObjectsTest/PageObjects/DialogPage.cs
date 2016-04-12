using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    public class DialogPage : Page
    {
        public bool CloseButtonExists
        {
            get { return Find<SilverlightButton>(By.AutomationId("M20jNVw1-U68UocgbPyajw")).Exists; }
        }
    }
}