using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfList
    /// </summary>
    public class CUITe_WpfList : CUITe_WpfControl<WpfList>
    {
        public CUITe_WpfList() : base() { }
        public CUITe_WpfList(string searchParameters) : base(searchParameters) { }

        public bool IsMultipleSelection
        {
            get { return this.UnWrap().IsMultipleSelection; }
        }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }

        public List<CUITe_WpfListItem> ItemsAsCUITe
        {
            get 
            {
                List<CUITe_WpfListItem> list = new List<CUITe_WpfListItem>();
                foreach (WpfListItem item in this.UnWrap().Items)
                {
                    CUITe_WpfListItem cuiteItem = new CUITe_WpfListItem();
                    cuiteItem.WrapReady(item);
                    list.Add(cuiteItem);
                }
                return list; 
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in this.UnWrap().Items select ((WpfListItem)x).DisplayText).ToList<string>(); }
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

        public string SelectedItemsAsString
        {
            get { return this.UnWrap().SelectedItemsAsString; }
            set { this.UnWrap().SelectedItemsAsString = value; }
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

    }
}