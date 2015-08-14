#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit.
    /// </summary>
    public class SilverlightEdit : SilverlightControl<CUITControls.SilverlightEdit>
    {
        public SilverlightEdit()
        {
        }

        public SilverlightEdit(string searchParameters)
            : base(searchParameters)
        {
        }

        /// <summary>
        /// Gets or sets the text displayed on the Silverlight Edit.
        /// </summary>
        public string Text
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Text;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.Text = value;
            }
        }

        public void SetText(string sText)
        {
            SourceControl.WaitForControlReady();
            SourceControl.Text = sText;
        }

        public string GetText()
        {
            SourceControl.WaitForControlReady();
            return SourceControl.Text;
        }

        public bool ReadOnly
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.ReadOnly;
            }
        }
    }
}
#endif