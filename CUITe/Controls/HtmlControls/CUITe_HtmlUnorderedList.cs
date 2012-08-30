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
        public CUITe_HtmlUnorderedList() : base() { }
        public CUITe_HtmlUnorderedList(string searchParameters) : base(searchParameters) { }

        public Type GetBaseType()
        {
            return typeof(HtmlCustom);
        }

        public void Wrap(object control)
        {
            this._control = control as HtmlCustom;
            this.fillSearchProperties();
            this._control.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "ul", PropertyExpressionOperator.EqualTo);
            this._control.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
        }
    }
}
