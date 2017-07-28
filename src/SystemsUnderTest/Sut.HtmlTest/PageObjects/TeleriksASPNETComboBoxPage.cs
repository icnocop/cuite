using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    /// <summary>
    /// Telerik ASP.NET ComoboBox Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class TeleriksASPNETComboBoxPage : Page
    {
        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        public HtmlEdit Product
        {
            get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxProduct_Input")); }
        }

        /// <summary>
        /// Gets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        public HtmlEdit Region
        {
            get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxRegion_Input")); }
        }

        /// <summary>
        /// Gets the dealer.
        /// </summary>
        /// <value>
        /// The dealer.
        /// </value>
        public HtmlEdit Dealer
        {
            get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxDealer_Input")); }
        }

        /// <summary>
        /// Gets the payment method.
        /// </summary>
        /// <value>
        /// The payment method.
        /// </value>
        public HtmlEdit PaymentMethod
        {
            get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxPaymentMethod_Input")); }
        }
    }
}