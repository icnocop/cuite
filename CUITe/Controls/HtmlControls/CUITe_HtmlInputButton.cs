using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlInputButton : CUITe_ControlBase
    {
        private HtmlInputButton _htmlInputButton;

        public CUITe_HtmlInputButton(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlInputButton control)
        {
            base.Wrap(control);
            this._htmlInputButton = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlInputButton control with a CUITe_HtmlInputButton to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlInputButton btnEdit = new CUITe_HtmlInputButton();
        /// btnEdit.WrapReady(edit);
        /// btnEdit.Click();
        /// </code>
        /// Here 'edit' is a HtmlInputButton object.
        /// </example>
        public void WrapReady(HtmlInputButton control)
        {
            base.WrapReady(control);
            this._htmlInputButton = control;
        }

        public HtmlInputButton UnWrap()
        {
            return this._htmlInputButton;
        }

        public string InnerText
        {
            get
            {
                return this._htmlInputButton.InnerText;
            }
        }

        public string DisplayText
        {
            get
            {
                return this._htmlInputButton.DisplayText;
            }
        }
    }
}
