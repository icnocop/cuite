﻿#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightLabel.
    /// </summary>
    public class SilverlightLabel : SilverlightControl<CUITControls.SilverlightLabel>
    {
        public SilverlightLabel() : base() { }
        public SilverlightLabel(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the text displayed on the label.
        /// </summary>
        public string Text
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Text;
            }
        }
    }
}
#endif