using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfMenu
    /// </summary>
    public class WpfMenu : WpfControl<CUIT.WpfMenu>
    {
        public WpfMenu() : base() { }
        public WpfMenu(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }

        public List<WpfMenuItem> ItemsAsCUITe
        {
            get
            {
                List<WpfMenuItem> list = new List<WpfMenuItem>();
                foreach (CUIT.WpfMenuItem item in this.UnWrap().Items)
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
            get { return (from x in this.UnWrap().Items select ((CUIT.WpfMenuItem)x).Header).ToList<string>(); }
        }

    }
}