using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class TestHtmlPage : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "A Test";
        public CUITe_HtmlParagraph p = new CUITe_HtmlParagraph("id=para1");
    }
}
