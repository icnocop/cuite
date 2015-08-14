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
        public WpfList() { }
        public WpfList(string searchParameters) : base(searchParameters) { }

        public bool IsMultipleSelection
        {
            get { return UnWrap().IsMultipleSelection; }
        }

        public UITestControlCollection Items
        {
            get { return UnWrap().Items; }
        }

        public List<WpfListItem> ItemsAsCUITe
        {
            get 
            {
                List<WpfListItem> list = new List<WpfListItem>();
                foreach (CUITControls.WpfListItem item in UnWrap().Items)
                {
                    WpfListItem cuiteItem = new WpfListItem();
                    cuiteItem.WrapReady(item);
                    list.Add(cuiteItem);
                }
                return list; 
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in UnWrap().Items select ((CUITControls.WpfListItem)x).DisplayText).ToList<string>(); }
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

        public string SelectedItemsAsString
        {
            get { return UnWrap().SelectedItemsAsString; }
            set { UnWrap().SelectedItemsAsString = value; }
        }

        public int SelectedIndex
        {
            get { return (UnWrap().SelectedIndices.Length > 0 ? UnWrap().SelectedIndices[0] : -1); }
            set { UnWrap().SelectedIndices = new[] { value }; }
        }

        public string SelectedItem
        {
            get { return (UnWrap().SelectedIndices.Length > 0 ? UnWrap().SelectedItems[0] : null); }
            set { UnWrap().SelectedItems = new[] { value }; }
        }

    }
}