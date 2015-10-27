using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.WorkflowsTest.ObjectRepository
{
    public class NamePage : Page
    {
        public string FirstName
        {
            set { Find<SilverlightEdit>(By.AutomationId("F4M4dWKkHUim_c0InT860A")).Text = value; }
        }

        public string Surname
        {
            set { Find<SilverlightEdit>(By.AutomationId("SF416_2UjEamJfUrETTf_g")).Text = value; }
        }

        public AddressPage ClickNext()
        {
            Find<SilverlightButton>(By.AutomationId("bjkpOK_yG0eXEweEXWbeTg")).Click();
            return GetComponent<AddressPage>();
        }
    }
}