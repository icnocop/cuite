using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfMenu
    /// </summary>
    public class CUITe_WpfMenu : CUITe_WpfControl<WpfMenu>
    {
        public CUITe_WpfMenu() : base() { }
        public CUITe_WpfMenu(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }

        public List<CUITe_WpfMenuItem> ItemsAsCUITe
        {
            get
            {
                List<CUITe_WpfMenuItem> list = new List<CUITe_WpfMenuItem>();
                foreach (WpfMenuItem item in this.UnWrap().Items)
                {
                    CUITe_WpfMenuItem cuiteItem = new CUITe_WpfMenuItem();
                    cuiteItem.WrapReady(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in this.UnWrap().Items select ((WpfMenuItem)x).Header).ToList<string>(); }
        }

    }
}