using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.SilverlightTest.PageObjects
{
    public class TestPage : Page
    {
        public SilverlightList List
        {
            get { return Find<SilverlightList>(By.AutomationId("listBox1")); }
        }
    }
}