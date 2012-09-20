using CUITe.Controls.HtmlControls;
using CUITe.Controls.TelerikControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class ASPNETComboBoxDemoFirstLook : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "ASP.NET ComboBox Demo - First Look";

        public Telerik_ComboBox combo1 = new Telerik_ComboBox("id=RadComboBoxProduct");
        public Telerik_ComboBox combo2 = new Telerik_ComboBox("id=RadComboBoxRegion");
        public Telerik_ComboBox combo3 = new Telerik_ComboBox("id=RadComboBoxDealer");
        public Telerik_ComboBox combo4 = new Telerik_ComboBox("id=RadComboBoxPaymentMethod");
        
    }
}

