using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfComboBox
    /// </summary>
    public class CUITe_WpfComboBox : CUITe_WpfControl<WpfComboBox>
    {
        public CUITe_WpfComboBox() : base() { }
        public CUITe_WpfComboBox(string searchParameters) : base(searchParameters) { }

        public string EditableItem
        {
            get { return this.UnWrap().EditableItem; }
            set { this.UnWrap().EditableItem = value; }
        }

        public bool Expanded
        {
            get { return this.UnWrap().Expanded; }
            set { this.UnWrap().Expanded = value; }
        }

        public bool IsEditable
        {
            get { return this.UnWrap().IsEditable; }
        }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in this.UnWrap().Items select ((WpfListItem)x).DisplayText).ToList<string>(); }
        }

        public int SelectedIndex
        {
            get { return this.UnWrap().SelectedIndex; }
            set { this.UnWrap().SelectedIndex = value; }
        }

        public string SelectedItem
        {
            get { return this.UnWrap().SelectedItem; }
            set { this.UnWrap().SelectedItem = value; }
        }
    }
}