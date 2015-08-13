using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension.Silverlight;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlScrollBar : CUITe_SlControl<SilverlightControl>
    {
        public CUITe_SlScrollBar() : base() { }
        public CUITe_SlScrollBar(string searchParameters) : base(searchParameters) { }
    }
}
