using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.WorkflowsTest.ObjectRepository
{
    public class NameScreenComponent : ScreenComponent
    {
        public string FirstName
        {
            set { Find<WpfEdit>(By.AutomationId("dKY2UyRoTEa_40c0jSEIuQ")).Text = value; }
        }

        public string Surname
        {
            set { Find<WpfEdit>(By.AutomationId("JQT9WV1Be0CN0ps04dxnww")).Text = value; }
        }

        public AddressScreenComponent ClickNext()
        {
            Find<WpfButton>(By.AutomationId("UXusDRFCMUu3uZqhbDDf0g")).Click();
            return GetComponent<AddressScreenComponent>();
        }
    }
}