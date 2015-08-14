using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfMenu
    /// </summary>
    public class WpfMenu : WpfControl<CUITControls.WpfMenu>
    {
        public WpfMenu() : base() { }
        public WpfMenu(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Items
        {
            get { return UnWrap().Items; }
        }

        public List<WpfMenuItem> ItemsAsCUITe
        {
            get
            {
                List<WpfMenuItem> list = new List<WpfMenuItem>();
                foreach (CUITControls.WpfMenuItem item in UnWrap().Items)
                {
                    WpfMenuItem cuiteItem = new WpfMenuItem();
                    cuiteItem.WrapReady(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in UnWrap().Items select ((CUITControls.WpfMenuItem)x).Header).ToList<string>(); }
        }

    }
}