#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit.
    /// </summary>
    public class SilverlightEdit : SilverlightControl<CUITControls.SilverlightEdit>
    {
        public SilverlightEdit() : base() { }
        public SilverlightEdit(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets or sets the text displayed on the Silverlight Edit.
        /// </summary>
        public string Text
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Text;
            }
            set
            {
                _control.WaitForControlReady();
                _control.Text = value;
            }
        }

        public void SetText(string sText)
        {
            _control.WaitForControlReady();
            _control.Text = sText;
        }

        public string GetText()
        {
            _control.WaitForControlReady();
            return _control.Text;  
        }

        public bool ReadOnly
        {
            get
            {
                _control.WaitForControlReady();
                return _control.ReadOnly;
            }
        }
    }
}
#endif