using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfComboBox
    /// </summary>
    public class WpfComboBox : WpfControl<CUITControls.WpfComboBox>
    {
        public WpfComboBox()
        {
        }

        public WpfComboBox(string searchParameters)
            : base(searchParameters)
        {
        }

        public string EditableItem
        {
            get { return UnWrap().EditableItem; }
            set { UnWrap().EditableItem = value; }
        }

        public bool Expanded
        {
            get { return UnWrap().Expanded; }
            set { UnWrap().Expanded = value; }
        }

        public bool IsEditable
        {
            get { return UnWrap().IsEditable; }
        }

        public UITestControlCollection Items
        {
            get { return UnWrap().Items; }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in UnWrap().Items select ((CUITControls.WpfListItem)x).DisplayText).ToList<string>(); }
        }

        public int SelectedIndex
        {
            get { return UnWrap().SelectedIndex; }
            set { UnWrap().SelectedIndex = value; }
        }

        public string SelectedItem
        {
            get { return UnWrap().SelectedItem; }
            set { UnWrap().SelectedItem = value; }
        }
    }
}