using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlButton : CUITe_ControlBase
    {
        private HtmlButton _htmlButton;

        public CUITe_HtmlButton(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlButton control)
        {
            base.Wrap(control);
            this._htmlButton = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlButton control with a CUITe_HtmlButton to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlButton btnEdit = new CUITe_HtmlButton();
        /// btnEdit.WrapReady(edit);
        /// btnEdit.Click();
        /// </code>
        /// Here 'edit' is a HtmlButton object.
        /// </example>
        public void WrapReady(HtmlButton control)
        {
            base.WrapReady(control);
            this._htmlButton = control;
        }

        public HtmlButton UnWrap()
        {
            return this._htmlButton;
        }
    }
}
