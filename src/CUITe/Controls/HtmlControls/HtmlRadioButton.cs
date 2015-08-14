using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlRadioButton : HtmlControl<CUITControls.HtmlRadioButton>
    {
        public HtmlRadioButton()
        {
        }

        public HtmlRadioButton(string searchParameters)
            : base(searchParameters)
        {
        }

        public void Select()
        {
            SourceControl.WaitForControlReady();
            SourceControl.Selected = true;
        }

        public void Select2()
        {
            SourceControl.WaitForControlReady();
            string sOnClick = (string)SourceControl.GetProperty("onclick");
            string sId = SourceControl.Id;
            if (sId == null || sId == "")
            {
                throw new GenericException("Select2(): No ID found for the RadioButton!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public bool IsSelected
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Selected;
            }
        }
    }
}