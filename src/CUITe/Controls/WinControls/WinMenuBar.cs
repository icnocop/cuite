using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinMenuBar
    /// </summary>
    public class WinMenuBar : WinControl<CUITControls.WinMenuBar>
    {
        public WinMenuBar()
        {
        }

        public WinMenuBar(string searchParameters)
            : base(searchParameters)
        {
        }

        public UITestControlCollection Items
        {
            get { return UnWrap().Items; }
        }

        public List<WinMenuItem> ItemsAsCUITe
        {
            get
            {
                List<WinMenuItem> list = new List<WinMenuItem>();
                foreach (CUITControls.WinMenuItem item in UnWrap().Items)
                {
                    WinMenuItem cuiteItem = new WinMenuItem();
                    cuiteItem.WrapReady(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in UnWrap().Items select ((CUITControls.WinMenuItem)x).DisplayText).ToList<string>(); }
        }
    }
}