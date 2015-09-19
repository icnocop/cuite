﻿using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePage : BrowserWindowUnderTest
    {
        public new string WindowTitle { get { return "Google"; } }
        public HtmlEdit txtSearch = new HtmlEdit(By.Id("lst-ib"));
    }
}
