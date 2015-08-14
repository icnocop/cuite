using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfRadioButton
    /// </summary>
    public class WpfRadioButton : WpfControl<CUITControls.WpfRadioButton>
    {
        public WpfRadioButton() : base() { }
        public WpfRadioButton(string searchParameters) : base(searchParameters) { }

        public UITestControl Group
        {
            get { return UnWrap().Group; }
        }

        public WpfGroup GroupAsCUITe
        {
            get
            {
                WpfGroup group = new WpfGroup();
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