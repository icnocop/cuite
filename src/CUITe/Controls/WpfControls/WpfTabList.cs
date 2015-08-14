using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabList
    /// </summary>
    public class WpfTabList : WpfControl<CUITControls.WpfTabList>
    {
        public WpfTabList()
        {
        }

        public WpfTabList(string searchParameters)
            : base(searchParameters)
        {
        }

        public int SelectedIndex
        {
            get { return UnWrap().SelectedIndex; }
            set { UnWrap().SelectedIndex = value; }
        }

        public UITestControlCollection Tabs
        {
            get { return UnWrap().Tabs; }
        }

        public List<WpfTabPage> TabsAsCUITe
        {
            get
            {
                List<WpfTabPage> list = new List<WpfTabPage>();
                foreach (CUITControls.WpfTabPage control in UnWrap().Tabs)
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