using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinMenuItem
    /// </summary>
    public class WinMenuItem : WinControl<CUITControls.WinMenuItem>
    {
        public WinMenuItem()
        {
        }

        public WinMenuItem(string searchParameters)
            : base(searchParameters)
        {
        }

        public bool Checked
        {
            get { return UnWrap().Checked; }
            set { UnWrap().Checked = value; }
        }

        public string DisplayText
        {
            get { return UnWrap().DisplayText; }
        }

        public bool HasChildNodes
        {
            get { return UnWrap().HasChildNodes; }
        }

        public bool IsTopLevelMenu
        {
            get { return UnWrap().IsTopLevelMenu; }
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

        public string Shortcut
        {
            get { return UnWrap().Shortcut; }
        }
    }
}