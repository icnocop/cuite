﻿using CUITe.Controls.HtmlControls;
using CUITe.Controls.TelerikControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Sut.HtmlTest.ObjectRepository
{
    public class DemosOfTeleriksASPNETComboBoxControl : BrowserWindowUnderTest
    {
        public new string WindowTitle { get { return "Demos of Telerik's ASP.NET ComboBox control"; } }
        public HtmlEdit Product { get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxProduct_Input")); } }
        public HtmlEdit Region { get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxRegion_Input")); } }
        public HtmlEdit Dealer { get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxDealer_Input")); } }
        public HtmlEdit PaymentMethod { get { return Find<HtmlEdit>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxPaymentMethod_Input")); } }

        public ComboBox cbProduct { get { return Find<ComboBox>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxProduct")); } }
        public ComboBox cbRegion { get { return Find<ComboBox>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxRegion", PropertyExpressionOperator.Contains)); } }
        public ComboBox cbDealer { get { return Find<ComboBox>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxDealer", PropertyExpressionOperator.Contains)); } }
        public ComboBox cbPaymentMethod { get { return Find<ComboBox>(By.Id("ctl00_ContentPlaceHolder1_RadComboBoxPaymentMethod", PropertyExpressionOperator.Contains)); } }
    }
}

