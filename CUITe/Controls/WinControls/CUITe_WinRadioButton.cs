using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRadioButton
    /// </summary>
    public class CUITe_WinRadioButton : CUITe_WinControl<WinRadioButton>
    {
        public CUITe_WinRadioButton() : base() { }
        public CUITe_WinRadioButton(string searchParameters) : base(searchParameters) { }

        public UITestControl Group
        {
            get { return this.UnWrap().Group; }
        }

        public CUITe_WinGroup GroupAsCUITe
        {
            get
            {
                CUITe_WinGroup group = new CUITe_WinGroup();
                group.WrapReady(this.UnWrap().Group);
                return group;
            }
        }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
            set { this.UnWrap().Selected = value; }
        }
    }
}