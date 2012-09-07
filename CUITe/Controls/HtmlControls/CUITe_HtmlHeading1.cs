using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading1 : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlHeading1()
            : base()
        {
            Initialize();
        }

        public CUITe_HtmlHeading1(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "h1", PropertyExpressionOperator.EqualTo);
        }
    }
}
