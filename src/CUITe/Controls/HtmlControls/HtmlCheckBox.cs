using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCheckBox : HtmlControl<CUITControls.HtmlCheckBox>
    {
        public HtmlCheckBox(string searchProperties = null)
            : this(new CUITControls.HtmlCheckBox(), searchProperties)
        {
        }

        public HtmlCheckBox(CUITControls.HtmlCheckBox sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public void Check()
        {
            WaitForControlReady();
            if (!SourceControl.Checked)
            {
                SourceControl.Checked = true;
            }
        }

        public void Check2()
        {
            WaitForControlReady();
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
            WaitForControlReady();
            if (SourceControl.Checked)
            {
                SourceControl.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Checked;
            }
        }
    }
}