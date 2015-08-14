using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlRadioButton : HtmlControl<CUITControls.HtmlRadioButton>
    {
        public HtmlRadioButton() { }
        public HtmlRadioButton(string searchParameters) : base(searchParameters) { }

        public void Select()
        {
            _control.WaitForControlReady();
            _control.Selected = true;
        }

        public void Select2()
        {
            _control.WaitForControlReady();
            string sOnClick = (string)_control.GetProperty("onclick");
            string sId = _control.Id;
            if (sId == null || sId == "")
            {
                throw new GenericException("Select2(): No ID found for the RadioButton!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public bool IsSelected
        {
            get {
                _control.WaitForControlReady();
                return _control.Selected; 
            }
        }
    }
}
