using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlList: CUITe_ControlBase
    {
        private HtmlList _htmlList;

        public CUITe_HtmlList(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlList control)
        {
            base.Wrap(control);
            this._htmlList = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlList control with a CUITe_HtmlList to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlList lstEdit = new CUITe_HtmlList();
        /// lstEdit.WrapReady(edit);
        /// lstEdit.Select("blah Blah Blah");
        /// </code>
        /// Here 'edit' is a HtmlList object.
        /// </example>
        public void WrapReady(HtmlList control)
        {
            base.WrapReady(control);
            this._htmlList = control;
        }

        public HtmlList UnWrap()
        {
            return this._htmlList;
        }

        public void Select(string sItem)
        {
            this._htmlList.WaitForControlReady();
            this._htmlList.SelectedItemsAsString = sItem;
        }
    }
}
