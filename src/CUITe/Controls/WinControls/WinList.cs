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
        public WinList()
        {
        }

        public WinList(string searchParameters)
            : base(searchParameters)
        {
        }

        public int[] CheckedIndices
        {
            get { return UnWrap().CheckedIndices; }
            set { UnWrap().CheckedIndices = value; }
        }

        public string[] CheckedItems
        {
            get { return UnWrap().CheckedItems; }
            set { UnWrap().CheckedItems = value; }
        }

        public UITestControlCollection Columns
        {
            get { return UnWrap().Columns; }
        }

        public UITestControl HorizontalScrollBar
        {
            get { return UnWrap().HorizontalScrollBar; }
        }

        public bool IsCheckedList
        {
            get { return UnWrap().IsCheckedList; }
        }

        public bool IsIconView
        {
            get { return UnWrap().IsIconView; }
        }

        public bool IsListView
        {
            get { return UnWrap().IsListView; }
        }

        public bool IsMultipleSelection
        {
            get { return UnWrap().IsMultipleSelection; }
        }

        public bool IsReportView
        {
            get { return UnWrap().IsReportView; }
        }

        public bool IsSmallIconView
        {
            get { return UnWrap().IsSmallIconView; }
        }

        public UITestControlCollection Items
        {
            get { return UnWrap().Items; }
        }

        public List<WinListItem> ItemsAsCUITe
        {
            get
            {
                List<WinListItem> list = new List<WinListItem>();
                foreach (CUITControls.WinListItem item in UnWrap().Items)
                {
                    WinListItem cuiteItem = new WinListItem();
                    cuiteItem.WrapReady(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in UnWrap().Items select ((CUITControls.WinListItem)x).DisplayText).ToList<string>(); }
        }

        public int[] SelectedIndices
        {
            get { return UnWrap().SelectedIndices; }
            set { UnWrap().SelectedIndices = value; }
        }

        public string[] SelectedItems
        {
            get { return UnWrap().SelectedItems; }
            set { UnWrap().SelectedItems = value; }
        }

        public int SelectedIndex
        {
            get { return (UnWrap().SelectedIndices.Length > 0 ? UnWrap().SelectedIndices[0] : -1); }
            set
            {
                UnWrap().SelectedIndices = new[]
                {
                    value
                };
            }
        }

        public string SelectedItem
        {
            get { return (UnWrap().SelectedIndices.Length > 0 ? UnWrap().SelectedItems[0] : null); }
            set
            {
                UnWrap().SelectedItems = new[]
                {
                    value
                };
            }
        }

        public string SelectedItemsAsString
        {
            get { return UnWrap().SelectedItemsAsString; }
            set { UnWrap().SelectedItemsAsString = value; }
        }

        public UITestControl VerticalScrollBar
        {
            get { return UnWrap().VerticalScrollBar; }
        }
    }
}