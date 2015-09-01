using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinMenuItem
    /// </summary>
    public class WinMenuItem : WinControl<CUITControls.WinMenuItem>
    {
        public WinMenuItem(string searchProperties = null)
            : this(new CUITControls.WinMenuItem(), searchProperties)
        {
        }

        public WinMenuItem(CUITControls.WinMenuItem sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        public bool IsTopLevelMenu
        {
            get { return SourceControl.IsTopLevelMenu; }
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

        public string Shortcut
        {
            get { return SourceControl.Shortcut; }
        }
    }
}