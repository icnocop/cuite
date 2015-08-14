using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTabList
    /// </summary>
    public class WinTabList : WinControl<CUITControls.WinTabList>
    {
        public WinTabList() { }
        public WinTabList(string searchParameters) : base(searchParameters) { }

        public int SelectedIndex
        {
            get { return UnWrap().SelectedIndex; }
            set { UnWrap().SelectedIndex = value; }
        }

        public UITestControlCollection Tabs
        {
            get { return UnWrap().Tabs; }
        }

        public List<WinTabPage> TabsAsCUITe
        {
            get
            {
                List<WinTabPage> list = new List<WinTabPage>();
                foreach (CUITControls.WinTabPage control in UnWrap().Tabs)
                {
                    WinTabPage tab = new WinTabPage();
                    tab.WrapReady(control);
                    list.Add(tab);
                }
                return list;
            }
        }

        public UITestControl TabSpinner
        {
            get { return UnWrap().TabSpinner; }
        }

    }
}