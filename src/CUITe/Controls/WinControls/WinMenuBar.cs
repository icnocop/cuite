using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinMenuBar
    /// </summary>
    public class WinMenuBar : WinControl<CUITControls.WinMenuBar>
    {
        public WinMenuBar(string searchProperties = null)
            : this(new CUITControls.WinMenuBar(), searchProperties)
        {
        }

        public WinMenuBar(CUITControls.WinMenuBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }

        public List<WinMenuItem> ItemsAsCUITe
        {
            get
            {
                List<WinMenuItem> list = new List<WinMenuItem>();
                foreach (CUITControls.WinMenuItem item in SourceControl.Items)
                {
                    WinMenuItem cuiteItem = new WinMenuItem(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in SourceControl.Items select ((CUITControls.WinMenuItem)x).DisplayText).ToList<string>(); }
        }
    }
}