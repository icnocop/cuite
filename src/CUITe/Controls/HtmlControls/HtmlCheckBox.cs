using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCheckBox : HtmlControl<CUITControls.HtmlCheckBox>
    {
        public HtmlCheckBox()
        {
        }

        public HtmlCheckBox(string searchParameters)
            : base(searchParameters)
        {
        }

        public void Check()
        {
            SourceControl.WaitForControlReady();
            if (!SourceControl.Checked)
            {
                SourceControl.Checked = true;
            }
        }

        public void Check2()
        {
            SourceControl.WaitForControlReady();
            string sOnClick = (string)SourceControl.GetProperty("onclick");
            string sId = SourceControl.Id;
            if (sId == null || sId == "")
            {
                throw new GenericException("Check2(): No ID found for the checkbox!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public void UnCheck()
        {
            SourceControl.WaitForControlReady();
            if (SourceControl.Checked)
            {
                SourceControl.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Checked;
            }
        }
    }
}