using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Sut.SilverlightTest.ObjectRepository
{
    public class TestPage : Page
    {
        public TestPage(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        public SilverlightList List
        {
            get { return Find<SilverlightList>(By.AutomationId("listBox1")); }
        }
    }
}