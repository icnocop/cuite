using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfComboBox
    /// </summary>
    public class WpfComboBox : WpfControl<CUITControls.WpfComboBox>
    {
        public WpfComboBox(By searchConfiguration = null)
            : this(new CUITControls.WpfComboBox(), searchConfiguration)
        {
        }

        public WpfComboBox(CUITControls.WpfComboBox sourceControl, By searchConfiguration = null)
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
            get { return (from x in SourceControl.Items select ((CUITControls.WpfListItem)x).DisplayText).ToList<string>(); }
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