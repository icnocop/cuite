using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class SlTestPage : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "Home";
        public CUITe_SlList oList = new CUITe_SlList("Name=listBox1");
    }
}
