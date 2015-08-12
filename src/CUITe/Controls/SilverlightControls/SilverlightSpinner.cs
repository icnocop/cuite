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
            : base()
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
            this.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Spinner", PropertyExpressionOperator.EqualTo);
        }

        private SilverlightEdit _TextBox
        {
            get
            {
                return Get<SilverlightEdit>();
            }
        }

        /// <summary>
        /// Gets or sets the text displayed on the Silverlight Spinner.
        /// </summary>
        public string Text
        {
            get
            {
                this._control.WaitForControlReady();



                return this._TextBox.Text;
            }
            set
            {
                this._control.WaitForControlReady();
                this._TextBox.Text = value;
            }
        }

        public void SetText(string sText)
        {
            this._control.WaitForControlReady();
            this._TextBox.Text = sText;
        }

        public string GetText()
        {
            this._control.WaitForControlReady();
            return this._TextBox.Text;
        }

        public bool ReadOnly
        {
            get
            {
                this._control.WaitForControlReady();
                return this._TextBox.ReadOnly;
            }
        }
    }
}
#endif