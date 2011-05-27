using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
	public class GoogleHomePage : CUITe_BrowserWindow
	{
		public new string sWindowTitle = "Google";
		public CUITe_HtmlEdit txtSearch = new CUITe_HtmlEdit("Name=q;Class=lst;Name=q;Title=Search");
		public CUITe_HtmlInputButton btnGoogleSearch = new CUITe_HtmlInputButton("Name=btnG;Class=lsb;Name=btnG;Value=Google Search");
		public CUITe_HtmlInputButton btnImFeelingLucky = new CUITe_HtmlInputButton("Name=btnI;Class=lsb;Name=btnI;Value=I'm Feeling Lucky");
        public CUITe_HtmlDiv divSearchResults = new CUITe_HtmlDiv("Id=res");
	}
}
