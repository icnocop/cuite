using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRadioButton
    /// </summary>
    public class WinRadioButton : WinControl<CUITControls.WinRadioButton>
    {
        public WinRadioButton(By searchConfiguration = null)
            : this(new CUITControls.WinRadioButton(), searchConfiguration)
        {
        }

        public WinRadioButton(CUITControls.WinRadioButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public UITestControl Group
        {
            get { return SourceControl.Group; }
        }

        public WinGroup GroupAsCUITe
        {
            get
            {
                WinGroup group = new WinGroup((CUITControls.WinGroup)Group);
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