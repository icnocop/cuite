using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfScrollBar
    /// </summary>
    public class CUITe_WpfScrollBar : CUITe_WpfControl<WpfScrollBar>
    {
        public CUITe_WpfScrollBar() : base() { }
        public CUITe_WpfScrollBar(string searchParameters) : base(searchParameters) { }

        public double MaximumPosition
        {
            get { return this.UnWrap().MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return this.UnWrap().MinimumPosition; }
        }

        public double Position
        {
            get { return this.UnWrap().Position; }
        }
    }
}