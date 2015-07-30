using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinMenuItem
    /// </summary>
    public class CUITe_WinMenuItem : CUITe_WinControl<WinMenuItem>
    {
        public CUITe_WinMenuItem() : base() { }
        public CUITe_WinMenuItem(string searchParameters) : base(searchParameters) { }

        public bool Checked
        {
            get { return this.UnWrap().Checked; }
            set { this.UnWrap().Checked = value; }
        }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }

        public bool HasChildNodes
        {
            get { return this.UnWrap().HasChildNodes; }
        }

        public bool IsTopLevelMenu
        {
            get { return this.UnWrap().IsTopLevelMenu; }
        }

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

        public string Shortcut
        {
            get { return this.UnWrap().Shortcut; }
        }

    }
}