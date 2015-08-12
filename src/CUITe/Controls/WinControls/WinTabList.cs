using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTabList
    /// </summary>
    public class WinTabList : WinControl<CUIT.WinTabList>
    {
        public WinTabList() : base() { }
        public WinTabList(string searchParameters) : base(searchParameters) { }

        public int SelectedIndex
        {
            get { return this.UnWrap().SelectedIndex; }
            set { this.UnWrap().SelectedIndex = value; }
        }

        public UITestControlCollection Tabs
        {
            get { return this.UnWrap().Tabs; }
        }

        public List<WinTabPage> TabsAsCUITe
        {
            get
            {
                List<WinTabPage> list = new List<WinTabPage>();
                foreach (CUIT.WinTabPage control in this.UnWrap().Tabs)
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
            get { return this.UnWrap().TabSpinner; }
        }

    }
}