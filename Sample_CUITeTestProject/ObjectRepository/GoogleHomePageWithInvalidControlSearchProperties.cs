using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class GoogleHomePageWithInvalidControlSearchProperties : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "Google";
        public CUITe_HtmlDiv controlWithInvalidSearchProperties = new CUITe_HtmlDiv("blanblah=res");
    }
}
