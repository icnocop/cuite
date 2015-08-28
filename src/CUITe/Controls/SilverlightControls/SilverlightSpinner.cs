#if SILVERLIGHT_SUPPORT
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for Silverlight Spinner.
    /// </summary>
    public class SilverlightSpinner : SilverlightControl<CUITControls.SilverlightControl>
    {
        public SilverlightSpinner(CUITControls.SilverlightControl sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightControl(), searchProperties)
        {
            SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Spinner", PropertyExpressionOperator.EqualTo);
        }

        private SilverlightEdit _TextBox
        {
            get { return Get<SilverlightEdit>(); }
        }

        /// <summary>
        /// Gets or sets the text displayed on the Silverlight Spinner.
        /// </summary>
        public string Text
        {
            get
            {
                WaitForControlReady();
                return _TextBox.Text;
            }
            set
            {
                WaitForControlReady();
                _TextBox.Text = value;
            }
        }

        public void SetText(string sText)
        {
            WaitForControlReady();
            _TextBox.Text = sText;
        }

        public string GetText()
        {
            WaitForControlReady();
            return _TextBox.Text;
        }

        public bool ReadOnly
        {
            get
            {
                WaitForControlReady();
                return _TextBox.ReadOnly;
            }
        }
    }
}
#endif