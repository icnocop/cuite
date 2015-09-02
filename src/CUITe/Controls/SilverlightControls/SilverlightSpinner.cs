using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

#if SILVERLIGHT_SUPPORT
namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for Silverlight Spinner.
    /// </summary>
    public class SilverlightSpinner : SilverlightControl<CUITControls.SilverlightControl>
    {
        public SilverlightSpinner(By searchConfiguration = null)
            : this(new CUITControls.SilverlightControl(), searchConfiguration)
        {
        }

        public SilverlightSpinner(CUITControls.SilverlightControl sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            AddSearchProperty(UITestControl.PropertyNames.ControlType, "Spinner");
        }

        private SilverlightEdit _TextBox
        {
            get { return Find<SilverlightEdit>(); }
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