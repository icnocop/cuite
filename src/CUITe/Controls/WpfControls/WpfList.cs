using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfList
    /// </summary>
    public class WpfList : WpfControl<CUITControls.WpfList>
    {
        public WpfList(string searchProperties = null)
            : this(new CUITControls.WpfList(), searchProperties)
        {
        }

        public WpfList(CUITControls.WpfList sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public bool IsMultipleSelection
        {
            get { return SourceControl.IsMultipleSelection; }
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }

        public List<WpfListItem> ItemsAsCUITe
        {
            get
            {
                List<WpfListItem> list = new List<WpfListItem>();
                foreach (CUITControls.WpfListItem item in SourceControl.Items)
                {
                    WpfListItem cuiteItem = new WpfListItem(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in SourceControl.Items select ((CUITControls.WpfListItem)x).DisplayText).ToList<string>(); }
        }

        public int[] SelectedIndices
        {
            get { return SourceControl.SelectedIndices; }
            set { SourceControl.SelectedIndices = value; }
        }

        public string[] SelectedItems
        {
            get { return SourceControl.SelectedItems; }
            set { SourceControl.SelectedItems = value; }
        }

        public string SelectedItemsAsString
        {
            get { return SourceControl.SelectedItemsAsString; }
            set { SourceControl.SelectedItemsAsString = value; }
        }

        public int SelectedIndex
        {
            get { return (SourceControl.SelectedIndices.Length > 0 ? SourceControl.SelectedIndices[0] : -1); }
            set
            {
                SourceControl.SelectedIndices = new[] { value };
            }
        }

        public string SelectedItem
        {
            get { return (SourceControl.SelectedIndices.Length > 0 ? SourceControl.SelectedItems[0] : null); }
            set
            {
                SourceControl.SelectedItems = new[] { value };
            }
        }
    }
}