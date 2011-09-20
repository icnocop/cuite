using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlTabItem : CUITe_ControlBase
    {
        private SilverlightTabItem _SlTabItem;

        public CUITe_SlTabItem(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightTabItem control)
        {
            base.Wrap(control);
            this._SlTabItem = control;
        }

        /// <summary>
        /// Helps you wrap a SilverlightTabItem control with a CUITe_SlTabItem to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_SlTabItem tabEdit = new CUITe_SlTabItem();
        /// tabEdit.WrapReady(edit);
        /// tabEdit.Click();
        /// </code>
        /// Here 'edit' is a SilverlightTabItem object.
        /// </example>
        public void WrapReady(SilverlightTabItem control)
        {
            base.WrapReady(control);
            this._SlTabItem = control;
        }

        public SilverlightTabItem UnWrap()
        {
            return this._SlTabItem;
        }
    }
}
