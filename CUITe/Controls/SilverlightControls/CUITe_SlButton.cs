using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlButton: CUITe_ControlBase
    {
        private SilverlightButton _SlButton;

        public CUITe_SlButton() : base() { }
        public CUITe_SlButton(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightButton control)
        {
            base.Wrap(control);
            this._SlButton = control;
        }

        /// <summary>
        /// Helps you wrap a SilverlightButton control with a CUITe_SlButton to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_SlButton btnEdit = new CUITe_SlButton();
        /// btnEdit.WrapReady(edit);
        /// btnEdit.Click();
        /// </code>
        /// Here 'edit' is a SilverlightButton object.
        /// </example>
        public void WrapReady(SilverlightButton control)
        {
            base.WrapReady(control);
            this._SlButton = control;
        }

        public SilverlightButton UnWrap()
        {
            return this._SlButton;
        }
    }
}
