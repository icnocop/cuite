using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinList
    /// </summary>
    public class CUITe_WinList : CUITe_WinControl<WinList>
    {
        public CUITe_WinList() : base() { }
        public CUITe_WinList(string searchParameters) : base(searchParameters) { }

        public int[] CheckedIndices
        {
            get { return this.UnWrap().CheckedIndices; }
            set { this.UnWrap().CheckedIndices = value; }
        }

        public string[] CheckedItems
        {
            get { return this.UnWrap().CheckedItems; }
            set { this.UnWrap().CheckedItems = value; }
        }

        public UITestControlCollection Columns
        {
            get { return this.UnWrap().Columns; }
        }

        public UITestControl HorizontalScrollBar
        {
            get { return this.UnWrap().HorizontalScrollBar; }
        }

        public bool IsCheckedList
        {
            get { return this.UnWrap().IsCheckedList; }
        }

        public bool IsIconView
        {
            get { return this.UnWrap().IsIconView; }
        }

        public bool IsListView
        {
            get { return this.UnWrap().IsListView; }
        }

        public bool IsMultipleSelection
        {
            get { return this.UnWrap().IsMultipleSelection; }
        }

        public bool IsReportView
        {
            get { return this.UnWrap().IsReportView; }
        }

        public bool IsSmallIconView
        {
            get { return this.UnWrap().IsSmallIconView; }
        }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }

        public List<CUITe_WinListItem> ItemsAsCUITe
        {
            get
            {
                List<CUITe_WinListItem> list = new List<CUITe_WinListItem>();
                foreach (WinListItem item in this.UnWrap().Items)
                {
                    CUITe_WinListItem cuiteItem = new CUITe_WinListItem();
                    cuiteItem.WrapReady(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in this.UnWrap().Items select ((WinListItem)x).DisplayText).ToList<string>(); }
        }

        public int[] SelectedIndices
        {
            get { return this.UnWrap().SelectedIndices; }
            set { this.UnWrap().SelectedIndices = value; }
        }

        public string[] SelectedItems
        {
            get { return this.UnWrap().SelectedItems; }
            set { this.UnWrap().SelectedItems = value; }
        }

        public int SelectedIndex
        {
            get { return (this.UnWrap().SelectedIndices.Length > 0 ? this.UnWrap().SelectedIndices[0] : -1); }
            set { this.UnWrap().SelectedIndices = new int[] { value }; }
        }

        public string SelectedItem
        {
            get { return (this.UnWrap().SelectedIndices.Length > 0 ? this.UnWrap().SelectedItems[0] : null); }
            set { this.UnWrap().SelectedItems = new string[] { value }; }
        }

        public string SelectedItemsAsString
        {
            get { return this.UnWrap().SelectedItemsAsString; }
            set { this.UnWrap().SelectedItemsAsString = value; }
        }

        public UITestControl VerticalScrollBar
        {
            get { return this.UnWrap().VerticalScrollBar; }
        }
    }
}
