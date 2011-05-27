using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class GoogleSearch : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "coded ui test framework - Google Search";
        public CUITe_HtmlDiv divSearchResults = new CUITe_HtmlDiv("Id=ires");
    }
}
