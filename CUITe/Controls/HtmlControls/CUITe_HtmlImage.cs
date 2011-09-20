using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlImage : CUITe_ControlBase
    {
        private HtmlImage _htmlImage;

        public CUITe_HtmlImage(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlImage control)
        {
            base.Wrap(control);
            this._htmlImage = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlImage control with a CUITe_HtmlImage to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlImage imgEdit = new CUITe_HtmlImage();
        /// imgEdit.WrapReady(edit);
        /// imgEdit.Click();
        /// </code>
        /// Here 'edit' is a HtmlImage object.
        /// </example>
        public void WrapReady(HtmlImage control)
        {
            base.WrapReady(control);
            this._htmlImage = control;
        }

        public HtmlImage UnWrap()
        {
            return this._htmlImage;
        }
    }
}
