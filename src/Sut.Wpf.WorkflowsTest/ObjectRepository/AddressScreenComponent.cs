using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.WorkflowsTest.ObjectRepository
{
    public class AddressScreenComponent : ScreenComponent
    {
        public string Address
        {
            set { Find<WpfEdit>(By.AutomationId("mdNHebXTWk-wyMAT-s9E9w")).Text = value; }
        }

        public string City
        {
            set { Find<WpfEdit>(By.AutomationId("-AznSNfwFECcKnlU7ZP-_A")).Text = value; }
        }

        public string State
        {
            set { Find<WpfEdit>(By.AutomationId("F5PsSJJtB0SqhBZdswzhaQ")).Text = value; }
        }

        public string PostalCode
        {
            set { Find<WpfEdit>(By.AutomationId("RjTuE6e3I06Q5mcPIS4uZw")).Text = value; }
        }

        public FinishedScreenComponent ClickNext()
        {
            Find<WpfButton>(By.AutomationId("UXusDRFCMUu3uZqhbDDf0g")).Click();
            return GetComponent<FinishedScreenComponent>();
        }
    }
}