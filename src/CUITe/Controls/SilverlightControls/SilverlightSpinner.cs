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
        public SilverlightSpinner()
        {
            Initialize();
        }

        public SilverlightSpinner(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
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
                SourceControl.WaitForControlReady();
                return _TextBox.Text;
            }
            set
            {
                SourceControl.WaitForControlReady();
                _TextBox.Text = value;
            }
        }

        public void SetText(string sText)
        {
            SourceControl.WaitForControlReady();
            _TextBox.Text = sText;
        }

        public string GetText()
        {
            SourceControl.WaitForControlReady();
            return _TextBox.Text;
        }

        public bool ReadOnly
        {
            get
            {
                SourceControl.WaitForControlReady();
                return _TextBox.ReadOnly;
            }
        }
    }
}
#endif