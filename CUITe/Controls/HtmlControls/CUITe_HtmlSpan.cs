using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlSpan : CUITe_ControlBase
    {
        private HtmlSpan _htmlSpan;

        public CUITe_HtmlSpan(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlSpan control)
        {
            base.Wrap(control);
            this._htmlSpan = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlSpan control with a CUITe_HtmlSpan to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlSpan spanEdit = new CUITe_HtmlSpan();
        /// spanEdit.WrapReady(edit);
        /// spanEdit.Click();
        /// </code>
        /// Here 'edit' is a HtmlSpan object.
        /// </example>
        public void WrapReady(HtmlSpan control)
        {
            base.WrapReady(control);
            this._htmlSpan = control;
        }

        public HtmlSpan UnWrap()
        {
            return this._htmlSpan;
        }

        public string InnerText
        {
            get
            {
                this._htmlSpan.WaitForControlReady();
                return this._htmlSpan.InnerText;
            }
        }
    }
}
