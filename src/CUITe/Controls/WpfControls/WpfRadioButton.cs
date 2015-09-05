using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfRadioButton
    /// </summary>
    public class WpfRadioButton : WpfControl<CUITControls.WpfRadioButton>
    {
        public WpfRadioButton(By searchConfiguration = null)
            : this(new CUITControls.WpfRadioButton(), searchConfiguration)
        {
        }

        public WpfRadioButton(CUITControls.WpfRadioButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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