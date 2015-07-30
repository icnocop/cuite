using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTabList
    /// </summary>
    public class CUITe_WinTabList : CUITe_WinControl<WinTabList>
    {
        public CUITe_WinTabList() : base() { }
        public CUITe_WinTabList(string searchParameters) : base(searchParameters) { }

        public int SelectedIndex
        {
            get { return this.UnWrap().SelectedIndex; }
            set { this.UnWrap().SelectedIndex = value; }
        }

        public UITestControlCollection Tabs
        {
            get { return this.UnWrap().Tabs; }
        }

        public List<CUITe_WinTabPage> TabsAsCUITe
        {
            get
            {
                List<CUITe_WinTabPage> list = new List<CUITe_WinTabPage>();
                foreach (WinTabPage control in this.UnWrap().Tabs)
                {
                    CUITe_WinTabPage tab = new CUITe_WinTabPage();
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