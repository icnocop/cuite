using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRadioButton
    /// </summary>
    public class WinRadioButton : WinControl<CUITControls.WinRadioButton>
    {
        public WinRadioButton()
        {
        }

        public WinRadioButton(string searchParameters)
            : base(searchParameters)
        {
        }

        public UITestControl Group
        {
            get { return UnWrap().Group; }
        }

        public WinGroup GroupAsCUITe
        {
            get
            {
                WinGroup group = new WinGroup();
                group.WrapReady(UnWrap().Group);
                return group;
            }
        }

        public bool Selected
        {
            get { return UnWrap().Selected; }
            set { UnWrap().Selected = value; }
        }
    }
}