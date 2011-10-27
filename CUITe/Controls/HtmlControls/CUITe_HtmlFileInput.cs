using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlFileInput : CUITe_HtmlControl<HtmlFileInput>
    {
        public CUITe_HtmlFileInput() : base() { }
        public CUITe_HtmlFileInput(string sSearchParameters) : base(sSearchParameters) { }

        public void SetFile(string sFilePath)
        {
            this._control.FileName = sFilePath;
        }
    }
}
