using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit.
    /// </summary>
    public class CUITe_SlEdit : CUITe_SlControl<SilverlightEdit>
    {
        public CUITe_SlEdit() : base() { }
        public CUITe_SlEdit(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets or sets the text displayed on the Silverlight Edit.
        /// </summary>
        public string Text
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Text;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.Text = value;
            }
        }

        public void SetText(string sText)
        {
            this._control.WaitForControlReady();
            this._control.Text = sText;
        }

        public string GetText()
        {
            this._control.WaitForControlReady();
            return this._control.Text;  
        }

        public bool ReadOnly
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ReadOnly;
            }
        }
    }
}
