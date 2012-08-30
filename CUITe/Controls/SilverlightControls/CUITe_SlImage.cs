using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightImage.
    /// </summary>
    public class CUITe_SlImage : CUITe_SlControl<SilverlightImage>
    {
        public CUITe_SlImage() : base() { }
        public CUITe_SlImage(string searchParameters) : base(searchParameters) { }
    }
}
