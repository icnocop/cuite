using System;
using System.Threading;
using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.TelerikControls
{
    /// <summary>
    /// Represents a Telerik combo box for Web page user interface (UI) testing.
    /// </summary>
    public class ComboBox : HtmlControl<CUITControls.HtmlDiv>
    {
        private readonly string id;
        private BrowserWindowUnderTest window;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBox"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public ComboBox(By searchConfiguration = null)
            : this(new CUITControls.HtmlDiv(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public ComboBox(CUITControls.HtmlDiv sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            PropertyExpression idSearchProperty = GetSearchProperty("id");
            if (idSearchProperty == null)
                throw new ArgumentException("Search configuration must contain the property name 'id'.", "searchConfiguration");

            id = idSearchProperty.PropertyValue;
        }

        /// <summary>
        /// Selects the combo box item with specified text.
        /// </summary>
        /// <param name="text">The text of the item to select.</param>
        /// <param name="milliseconds">
        /// The timeout in milliseconds before setting the selected item.
        /// </param>
        /// <exception cref="System.InvalidOperationException">
        /// Window where combo box is located is null.
        /// </exception>
        public void SelectItemByText(string text, int milliseconds)
        {
            if (window == null)
                throw new InvalidOperationException("Window must be set before calling this method.");

            window.RunScript("var obj = window.$find('" + id + "');obj.toggleDropDown();");
            Thread.Sleep(milliseconds);
            window.RunScript("var obj = window.$find('" + id + "');obj.findItemByText('" + text + "').select();obj.hideDropDown();");
        }

        internal void SetWindow(BrowserWindowUnderTest window)
        {
            this.window = window;
        }
    }
}