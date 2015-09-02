using System;
using System.Threading;
using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.TelerikControls
{
    public class ComboBox : HtmlControl<CUITControls.HtmlDiv>
    {
        private readonly string id;
        private BrowserWindowUnderTest window;

        public ComboBox(By searchConfiguration = null)
            : this(new CUITControls.HtmlDiv(), searchConfiguration)
        {
        }

        public ComboBox(CUITControls.HtmlDiv sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            PropertyExpression idSearchProperty = GetSearchProperty("id");
            if (idSearchProperty == null)
                throw new ArgumentException("Search properties must contain the property name 'id'.", "searchProperties");

            id = idSearchProperty.PropertyValue;
        }

        public void SelectItemByText(string sText, int milliseconds)
        {
            if (window == null)
                throw new InvalidOperationException("Window must be set before calling this method.");

            window.RunScript("var obj = window.$find('" + id + "');obj.toggleDropDown();");
            Thread.Sleep(milliseconds);
            window.RunScript("var obj = window.$find('" + id + "');obj.findItemByText('" + sText + "').select();obj.hideDropDown();");
        }

        internal void SetWindow(BrowserWindowUnderTest window)
        {
            this.window = window;
        }
    }
}