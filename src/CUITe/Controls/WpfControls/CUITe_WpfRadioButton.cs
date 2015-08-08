using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfRadioButton
    /// </summary>
    public class CUITe_WpfRadioButton : CUITe_WpfControl<WpfRadioButton>
    {
        public CUITe_WpfRadioButton() : base() { }
        public CUITe_WpfRadioButton(string searchParameters) : base(searchParameters) { }

        public UITestControl Group
        {
            get { return this.UnWrap().Group; }
        }

        public CUITe_WpfGroup GroupAsCUITe
        {
            get
            {
                CUITe_WpfGroup group = new CUITe_WpfGroup();
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