using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlListItem : CUITe_SlControl<SilverlightListItem>

    {
        public CUITe_SlListItem() : base() { }
        public CUITe_SlListItem(string searchParameters) : base(searchParameters) { }

    }
}
