using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabList
    /// </summary>
    public class CUITe_WpfTabList : CUITe_WpfControl<WpfTabList>
    {
        public CUITe_WpfTabList() : base() { }
        public CUITe_WpfTabList(string searchParameters) : base(searchParameters) { }

        public int SelectedIndex
        {
            get { return this.UnWrap().SelectedIndex; }
            set { this.UnWrap().SelectedIndex = value; }
        }

        public UITestControlCollection Tabs
        {
            get { return this.UnWrap().Tabs; }
        }

        public List<CUITe_WpfTabPage> TabsAsCUITe
        {
            get
            {
                List<CUITe_WpfTabPage> list = new List<CUITe_WpfTabPage>();
                foreach (WpfTabPage control in this.UnWrap().Tabs)
                {
                    CUITe_WpfTabPage tab = new CUITe_WpfTabPage();
                    tab.WrapReady(control);
                    list.Add(tab);
                }
                return list;
            }
        }

    }
}