using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlParagraph : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlParagraph()
            : base()
        {
            Initialize();
        }

        public CUITe_HtmlParagraph(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "p", PropertyExpressionOperator.EqualTo);
        }
    }
}
