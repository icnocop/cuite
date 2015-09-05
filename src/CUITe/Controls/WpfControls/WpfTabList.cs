using System.Collections.Generic;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabList
    /// </summary>
    public class WpfTabList : WpfControl<CUITControls.WpfTabList>
    {
        public WpfTabList(By searchConfiguration = null)
            : this(new CUITControls.WpfTabList(), searchConfiguration)
        {
        }

        public WpfTabList(CUITControls.WpfTabList sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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

        public List<WpfTabPage> TabsAsCUITe
        {
            get
            {
                List<WpfTabPage> list = new List<WpfTabPage>();
                foreach (CUITControls.WpfTabPage control in SourceControl.Tabs)
                {
                    WpfTabPage tab = new WpfTabPage(control);
                    list.Add(tab);
                }
                return list;
            }
        }
    }
}