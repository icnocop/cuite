#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit.
    /// </summary>
    public class SilverlightEdit : SilverlightControl<CUITControls.SilverlightEdit>
    {
        public SilverlightEdit(CUITControls.SilverlightEdit sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightEdit(), searchProperties)
        {
        }

        /// <summary>
        /// Gets or sets the text displayed on the Silverlight Edit.
        /// </summary>
        public string Text
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Text;
            }
            set
            {
                WaitForControlReady();
                SourceControl.Text = value;
            }
        }

        public void SetText(string sText)
        {
            WaitForControlReady();
            SourceControl.Text = sText;
        }

        public string GetText()
        {
            WaitForControlReady();
            return SourceControl.Text;
        }

        public bool ReadOnly
        {
            get
            {
                WaitForControlReady();
                return SourceControl.ReadOnly;
            }
        }
    }
}
#endif