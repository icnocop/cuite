using CUITe.Controls.HtmlControls;
using CUITe.Controls.TelerikControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class DemosOfTeleriksASPNETComboBoxControl : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "Demos of Telerik's ASP.NET ComboBox control";

        public CUITe_HtmlEdit Product { get { return Get<CUITe_HtmlEdit>("Id=ctl00_ContentPlaceHolder1_RadComboBoxProduct_Input"); } }
        public CUITe_HtmlEdit Region { get { return Get<CUITe_HtmlEdit>("Id=ctl00_ContentPlaceHolder1_RadComboBoxRegion_Input"); } }
        public CUITe_HtmlEdit Dealer { get { return Get<CUITe_HtmlEdit>("Id=ctl00_ContentPlaceHolder1_RadComboBoxDealer_Input"); } }
        public CUITe_HtmlEdit PaymentMethod { get { return Get<CUITe_HtmlEdit>("Id=ctl00_ContentPlaceHolder1_RadComboBoxPaymentMethod_Input"); } }

        public Telerik_ComboBox cbProduct { get { return Get<Telerik_ComboBox>("id=ctl00_ContentPlaceHolder1_RadComboBoxProduct"); } }
        public Telerik_ComboBox cbRegion { get { return Get<Telerik_ComboBox>("id~ctl00_ContentPlaceHolder1_RadComboBoxRegion"); } }
        public Telerik_ComboBox cbDealer { get { return Get<Telerik_ComboBox>("id~ctl00_ContentPlaceHolder1_RadComboBoxDealer"); } }
        public Telerik_ComboBox cbPaymentMethod { get { return Get<Telerik_ComboBox>("id~ctl00_ContentPlaceHolder1_RadComboBoxPaymentMethod"); } }
    }
}

