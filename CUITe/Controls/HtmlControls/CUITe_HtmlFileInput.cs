using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlFileInput : CUITe_ControlBase
    {
        private HtmlFileInput _htmlFileInput;

        public CUITe_HtmlFileInput() : base() { }
        public CUITe_HtmlFileInput(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlFileInput control)
        {
            base.Wrap(control);
            this._htmlFileInput = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlFileInput control with a CUITe_HtmlFileInput to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlFileInput finEdit = new CUITe_HtmlFileInput();
        /// finEdit.WrapReady(edit);
        /// finEdit.Click();
        /// </code>
        /// Here 'edit' is a HtmlFileInput object.
        /// </example>
        public void WrapReady(HtmlFileInput control)
        {
            base.WrapReady(control);
            this._htmlFileInput = control;
        }

        public HtmlFileInput UnWrap()
        {
            return this._htmlFileInput;
        }

        public void SetFile(string sFilePath)
        {
            this._htmlFileInput.FileName = sFilePath;
        }
    }
}
