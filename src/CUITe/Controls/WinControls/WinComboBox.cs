using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinComboBox
    /// </summary>
    public class WinComboBox : WinControl<CUITControls.WinComboBox>
    {
        public WinComboBox()
        {
        }

        public WinComboBox(string searchParameters)
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
            get { return (from x in UnWrap().Items select ((CUITControls.WinListItem)x).DisplayText).ToList<string>(); }
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