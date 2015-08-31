using System;
using System.Threading;
using CUITe.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.TelerikControls
{
    public class ComboBox : HtmlControl<CUITControls.HtmlDiv>
    {
        private readonly string id;
        private BrowserWindowUnderTest window;

        public ComboBox(string searchProperties = null)
            : this(new CUITControls.HtmlDiv(), searchProperties)
        {
        }

        public ComboBox(CUITControls.HtmlDiv sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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