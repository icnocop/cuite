using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightButton.
    /// </summary>
    public class CUITe_SlButton : CUITe_SlControl<SilverlightButton>
    {
        public CUITe_SlButton() : base() { }
        public CUITe_SlButton(string sSearchParameters) : base(sSearchParameters) { }

        /// <summary>
        /// Gets the text displayed on the Silverlight Button.
        /// </summary>
        public string DisplayText
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.DisplayText;
            }
        }
    }
}
