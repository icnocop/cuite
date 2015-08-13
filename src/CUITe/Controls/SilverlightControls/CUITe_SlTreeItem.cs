using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
using CUITe.Extensions;
using CUITe.Controls.HtmlControls;
//using Microsoft.VisualStudio.TestTools.UITest.Extension.
using CUITe.Controls.SilverlightControls;

namespace CUITe.Extensions.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTree.
    /// </summary>
    public class CUITe_SlTreeItem : CUITe_SlControl<SilverlightTreeItem>
    {
        public CUITe_SlTreeItem() : base() { }
        public CUITe_SlTreeItem(string searchParameters) : base(searchParameters) { }
    }
}
