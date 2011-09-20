using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlDataPager: CUITe_ControlBase
    {
        private SilverlightDataPager _SlDataPager;

        public CUITe_SlDataPager(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightDataPager control)
        {
            base.Wrap(control);
            this._SlDataPager = control;
        }

        /// <summary>
        /// Helps you wrap a SilverlightDataPager with a CUITe_SlDataPager to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_SlDataPager slEdit = new CUITe_SlDataPager();
        /// slEdit.WrapReady(edit);
        /// slEdit.Click();
        /// </code>
        /// Here 'edit' is a SilverlightDataPager object.
        /// </example>
        public void WrapReady(SilverlightDataPager control)
        {
            base.WrapReady(control);
            this._SlDataPager = control;
        }

        public SilverlightDataPager UnWrap()
        {
            return this._SlDataPager;
        }
    }
}
