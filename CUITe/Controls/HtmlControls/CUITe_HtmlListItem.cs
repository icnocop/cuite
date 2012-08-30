using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlListItem : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlListItem() : base() { }
        public CUITe_HtmlListItem(string searchParameters) : base(searchParameters) { }

        public Type GetBaseType()
        {
            return typeof(HtmlCustom);
        }

        public void Wrap(object control)
        {
            this._control = control as HtmlCustom;
            this.fillSearchProperties();
            this._control.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "li", PropertyExpressionOperator.EqualTo);
            this._control.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
        }
    }
}
