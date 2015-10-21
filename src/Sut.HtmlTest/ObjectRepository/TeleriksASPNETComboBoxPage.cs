using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class TeleriksASPNETComboBoxPage : Page
    {
        public HtmlEdit Product
        {
            get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxProduct_Input")); }
        }

        public HtmlEdit Region
        {
            get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxRegion_Input")); }
        }

        public HtmlEdit Dealer
        {
            get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxDealer_Input")); }
        }

        public HtmlEdit PaymentMethod
        {
            get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxPaymentMethod_Input")); }
        }
    }
}