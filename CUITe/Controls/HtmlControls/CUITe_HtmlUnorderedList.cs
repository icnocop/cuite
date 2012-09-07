using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlUnorderedList : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlUnorderedList()
            : base()
        {
            Initialize();
        }

        public CUITe_HtmlUnorderedList(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "ul", PropertyExpressionOperator.EqualTo);
        }
    }
}
