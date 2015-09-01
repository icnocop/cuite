using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfRadioButton
    /// </summary>
    public class WpfRadioButton : WpfControl<CUITControls.WpfRadioButton>
    {
        public WpfRadioButton(string searchProperties = null)
            : this(new CUITControls.WpfRadioButton(), searchProperties)
        {
        }

        public WpfRadioButton(CUITControls.WpfRadioButton sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public UITestControl Group
        {
            get { return SourceControl.Group; }
        }

        public WpfGroup GroupAsCUITe
        {
            get
            {
                WpfGroup group = new WpfGroup((CUITControls.WpfGroup)Group);
                return group;
            }
        }

        public bool Selected
        {
            get { return SourceControl.Selected; }
            set { SourceControl.Selected = value; }
        }
    }
}