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
        public WpfTabList(string searchProperties = null)
            : this(new CUITControls.WpfTabList(), searchProperties)
        {
        }

        public WpfTabList(CUITControls.WpfTabList sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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