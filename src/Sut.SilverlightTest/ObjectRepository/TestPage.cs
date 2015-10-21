using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.SilverlightTest.ObjectRepository
{
    public class TestPage : Page
    {
        public SilverlightList List
        {
            get { return Find<SilverlightList>(By.AutomationId("listBox1")); }
        }
    }
}