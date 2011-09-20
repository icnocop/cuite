using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlText : CUITe_ControlBase
    {
        private SilverlightText _SlText;

        public CUITe_SlText(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightText control)
        {
            base.Wrap(control);
            this._SlText = control;
        }

        /// <summary>
        /// Helps you wrap a SilverlightText control with a CUITe_SlText to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_SlText txtEdit = new CUITe_SlText();
        /// txtEdit.WrapReady(edit);
        /// txtEdit.SetText("Coded UI Test enhanced Framework");
        /// </code>
        /// Here 'edit' is a SilverlightText object.
        /// </example>
        public void WrapReady(SilverlightText control)
        {
            base.WrapReady(control);
            this._SlText = control;
        }

        public SilverlightText UnWrap()
        {
            return this._SlText;
        }
    }
}
