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
            _control.WaitForControlReady();
            if (!_control.Checked)
            {
                _control.Checked = true;
            }
        }

        public void Check2()
        {
            _control.WaitForControlReady();
            string sOnClick = (string)_control.GetProperty("onclick");
            string sId = _control.Id;
            if (sId == null || sId == "")
            {
                throw new GenericException("Check2(): No ID found for the checkbox!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public void UnCheck()
        {
            _control.WaitForControlReady();
            if (_control.Checked)
            {
                _control.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Checked;
            }
        }
    }
}