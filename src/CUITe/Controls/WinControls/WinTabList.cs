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
        public WinTabList(CUITControls.WinTabList sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinTabList(), searchProperties)
        {
        }

        public int SelectedIndex
        {
            get { return SourceControl.SelectedIndex; }
            set { SourceControl.SelectedIndex = value; }
        }

        public UITestControlCollection Tabs
        {
            get { return SourceControl.Tabs; }
        }

        public List<WinTabPage> TabsAsCUITe
        {
            get
            {
                List<WinTabPage> list = new List<WinTabPage>();
                foreach (CUITControls.WinTabPage control in SourceControl.Tabs)
                {
                    WinTabPage tab = new WinTabPage(control);
                    list.Add(tab);
                }
                return list;
            }
        }

        public UITestControl TabSpinner
        {
            get { return SourceControl.TabSpinner; }
        }
    }
}