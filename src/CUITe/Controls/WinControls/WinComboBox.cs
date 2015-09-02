using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinComboBox
    /// </summary>
    public class WinComboBox : WinControl<CUITControls.WinComboBox>
    {
        public WinComboBox(By searchConfiguration = null)
            : this(new CUITControls.WinComboBox(), searchConfiguration)
        {
        }

        public WinComboBox(CUITControls.WinComboBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string EditableItem
        {
            get { return SourceControl.EditableItem; }
            set { SourceControl.EditableItem = value; }
        }

        public bool Expanded
        {
            get { return SourceControl.Expanded; }
            set { SourceControl.Expanded = value; }
        }

        public bool IsEditable
        {
            get { return SourceControl.IsEditable; }
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in SourceControl.Items select ((CUITControls.WinListItem)x).DisplayText).ToList<string>(); }
        }

        public int SelectedIndex
        {
            get { return SourceControl.SelectedIndex; }
            set { SourceControl.SelectedIndex = value; }
        }

        public string SelectedItem
        {
            get { return SourceControl.SelectedItem; }
            set { SourceControl.SelectedItem = value; }
        }
    }
}