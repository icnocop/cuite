﻿using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.Mappings
{
    public class GoogleHomePageWithInvalidControlSearchProperties : BrowserWindowUnderTest
    {
        public new string WindowTitle { get { return "Google"; } }
        public HtmlDiv controlWithInvalidSearchProperties = new HtmlDiv(By.SearchProperties("blanblah=res"));
    }
}