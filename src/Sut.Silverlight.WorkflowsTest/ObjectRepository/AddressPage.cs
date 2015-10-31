using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.WorkflowsTest.ObjectRepository
{
    public class AddressPage : Page
    {
        public string Address
        {
            set { Find<SilverlightEdit>(By.AutomationId("qIbEFMPVDkKVav6IoeW6lw")).Text = value; }
        }

        public string City
        {
            set { Find<SilverlightEdit>(By.AutomationId("jpZqSIgz6E-OZYvjRENYqA")).Text = value; }
        }

        public string PostalCode
        {
            set { Find<SilverlightEdit>(By.AutomationId("88A1x0OcjEKBUFdSkGyHbg")).Text = value; }
        }

        public string State
        {
            set { Find<SilverlightEdit>(By.AutomationId("MjZSFASTiUC-DXKvXnFVyA")).Text = value; }
        }

        public FinishedPage ClickNext()
        {
            Find<SilverlightButton>(By.AutomationId("bjkpOK_yG0eXEweEXWbeTg")).Click();
            return GetComponent<FinishedPage>();
        }
    }
}