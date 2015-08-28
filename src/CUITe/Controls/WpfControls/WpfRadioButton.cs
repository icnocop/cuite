using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfRadioButton
    /// </summary>
    public class WpfRadioButton : WpfControl<CUITControls.WpfRadioButton>
    {
        public WpfRadioButton(CUITControls.WpfRadioButton sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfRadioButton(), searchProperties)
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