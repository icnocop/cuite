using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRadioButton
    /// </summary>
    public class WinRadioButton : WinControl<CUITControls.WinRadioButton>
    {
        public WinRadioButton(CUITControls.WinRadioButton sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinRadioButton(), searchProperties)
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