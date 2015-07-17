using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinMenu
    /// </summary>
    public class CUITe_WinMenu : CUITe_WinControl<WinMenu>
    {
        public CUITe_WinMenu() : base() { }
        public CUITe_WinMenu(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }

        public List<CUITe_WinMenuItem> ItemsAsCUITe
        {
            get
            {
                List<CUITe_WinMenuItem> list = new List<CUITe_WinMenuItem>();
                foreach (WinMenuItem item in this.UnWrap().Items)
                {
                    CUITe_WinMenuItem cuiteItem = new CUITe_WinMenuItem();
                    cuiteItem.WrapReady(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in this.UnWrap().Items select ((WinMenuItem)x).DisplayText).ToList<string>(); }
        }
    }
}