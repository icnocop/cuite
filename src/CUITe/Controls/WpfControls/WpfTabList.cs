using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabList
    /// </summary>
    public class WpfTabList : WpfControl<CUIT.WpfTabList>
    {
        public WpfTabList() : base() { }
        public WpfTabList(string searchParameters) : base(searchParameters) { }

        public int SelectedIndex
        {
            get { return this.UnWrap().SelectedIndex; }
            set { this.UnWrap().SelectedIndex = value; }
        }

        public UITestControlCollection Tabs
        {
            get { return this.UnWrap().Tabs; }
        }

        public List<WpfTabPage> TabsAsCUITe
        {
            get
            {
                List<WpfTabPage> list = new List<WpfTabPage>();
                foreach (CUIT.WpfTabPage control in this.UnWrap().Tabs)
                {
                    WpfTabPage tab = new WpfTabPage();
                    tab.WrapReady(control);
                    list.Add(tab);
                }
                return list;
            }
        }

    }
}