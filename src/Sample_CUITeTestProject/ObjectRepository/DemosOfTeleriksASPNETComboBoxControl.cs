using CUITe.Controls.HtmlControls;
using CUITe.Controls.TelerikControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class DemosOfTeleriksASPNETComboBoxControl : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "Demos of Telerik's ASP.NET ComboBox control";

        public HtmlEdit Product { get { return Get<HtmlEdit>("Id=ctl00_ContentPlaceHolder1_RadComboBoxProduct_Input"); } }
        public HtmlEdit Region { get { return Get<HtmlEdit>("Id=ctl00_ContentPlaceHolder1_RadComboBoxRegion_Input"); } }
        public HtmlEdit Dealer { get { return Get<HtmlEdit>("Id=ctl00_ContentPlaceHolder1_RadComboBoxDealer_Input"); } }
        public HtmlEdit PaymentMethod { get { return Get<HtmlEdit>("Id=ctl00_ContentPlaceHolder1_RadComboBoxPaymentMethod_Input"); } }

        public ComboBox cbProduct { get { return Get<ComboBox>("id=ctl00_ContentPlaceHolder1_RadComboBoxProduct"); } }
        public ComboBox cbRegion { get { return Get<ComboBox>("id~ctl00_ContentPlaceHolder1_RadComboBoxRegion"); } }
        public ComboBox cbDealer { get { return Get<ComboBox>("id~ctl00_ContentPlaceHolder1_RadComboBoxDealer"); } }
        public ComboBox cbPaymentMethod { get { return Get<ComboBox>("id~ctl00_ContentPlaceHolder1_RadComboBoxPaymentMethod"); } }
    }
}

