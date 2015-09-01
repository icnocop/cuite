using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinList
    /// </summary>
    public class WinList : WinControl<CUITControls.WinList>
    {
        public WinList(string searchProperties = null)
            : this(new CUITControls.WinList(), searchProperties)
        {
        }

        public WinList(CUITControls.WinList sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public int[] CheckedIndices
        {
            get { return SourceControl.CheckedIndices; }
            set { SourceControl.CheckedIndices = value; }
        }

        public string[] CheckedItems
        {
            get { return SourceControl.CheckedItems; }
            set { SourceControl.CheckedItems = value; }
        }

        public UITestControlCollection Columns
        {
            get { return SourceControl.Columns; }
        }

        public UITestControl HorizontalScrollBar
        {
            get { return SourceControl.HorizontalScrollBar; }
        }

        public bool IsCheckedList
        {
            get { return SourceControl.IsCheckedList; }
        }

        public bool IsIconView
        {
            get { return SourceControl.IsIconView; }
        }

        public bool IsListView
        {
            get { return SourceControl.IsListView; }
        }

        public bool IsMultipleSelection
        {
            get { return SourceControl.IsMultipleSelection; }
        }

        public bool IsReportView
        {
            get { return SourceControl.IsReportView; }
        }

        public bool IsSmallIconView
        {
            get { return SourceControl.IsSmallIconView; }
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }

        public List<WinListItem> ItemsAsCUITe
        {
            get
            {
                List<WinListItem> list = new List<WinListItem>();
                foreach (CUITControls.WinListItem item in SourceControl.Items)
                {
                    WinListItem cuiteItem = new WinListItem(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in SourceControl.Items select ((CUITControls.WinListItem)x).DisplayText).ToList<string>(); }
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

        public int SelectedIndex
        {
            get { return (SourceControl.SelectedIndices.Length > 0 ? SourceControl.SelectedIndices[0] : -1); }
            set
            {
                SourceControl.SelectedIndices = new[]
                {
                    value
                };
            }
        }

        public string SelectedItem
        {
            get { return (SourceControl.SelectedIndices.Length > 0 ? SourceControl.SelectedItems[0] : null); }
            set
            {
                SourceControl.SelectedItems = new[]
                {
                    value
                };
            }
        }

        public string SelectedItemsAsString
        {
            get { return SourceControl.SelectedItemsAsString; }
            set { SourceControl.SelectedItemsAsString = value; }
        }

        public UITestControl VerticalScrollBar
        {
            get { return SourceControl.VerticalScrollBar; }
        }
    }
}