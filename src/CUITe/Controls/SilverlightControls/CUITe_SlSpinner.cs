using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for Silverlight Spinner.
    /// </summary>
    public class CUITe_SlSpinner : CUITe_SlControl<SilverlightControl>
    {
        public CUITe_SlSpinner()
            : base()
        {
            Initialize();
        }

        public CUITe_SlSpinner(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Spinner", PropertyExpressionOperator.EqualTo);
        }

        private CUITe_SlEdit _TextBox
        {
            get
            {
                return Get<CUITe_SlEdit>();
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
