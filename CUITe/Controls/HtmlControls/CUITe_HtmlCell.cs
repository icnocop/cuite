using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlCell : CUITe_ControlBase
    {
        private HtmlCell _htmlCell;

        public CUITe_HtmlCell(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlCell control)
        {
            base.Wrap(control);
            this._htmlCell = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlCell control with a CUITe_HtmlCell to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlCell clEdit = new CUITe_HtmlCell();
        /// clEdit.WrapReady(edit);
        /// clEdit.Click();
        /// </code>
        /// Here 'edit' is a HtmlCell object.
        /// </example>
        public void WrapReady(HtmlCell control)
        {
            base.WrapReady(control);
            this._htmlCell = control;
        }

        public HtmlCell UnWrap()
        {
            return this._htmlCell;
        }
    }
}
