using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHyperlink : CUITe_ControlBase
    {
        private HtmlHyperlink _htmlHyperlink;

        public CUITe_HtmlHyperlink(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlHyperlink control)
        {
            base.Wrap(control);
            this._htmlHyperlink = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlHyperlink control with a CUITe_HtmlHyperlink to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlHyperlink hrefEdit = new CUITe_HtmlHyperlink();
        /// hrefEdit.WrapReady(edit);
        /// hrefEdit.Click();
        /// </code>
        /// Here 'edit' is a HtmlHyperlink object.
        /// </example>
        public void WrapReady(HtmlHyperlink control)
        {
            base.WrapReady(control);
            this._htmlHyperlink = control;
        }

        public HtmlHyperlink UnWrap()
        {
            return this._htmlHyperlink;
        }
    }
}
