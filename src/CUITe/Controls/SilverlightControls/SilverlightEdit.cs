#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit.
    /// </summary>
    public class SilverlightEdit : SilverlightControl<CUITControls.SilverlightEdit>
    {
        public SilverlightEdit(string searchProperties = null)
            : this(new CUITControls.SilverlightEdit(), searchProperties)
        {
        }

        public SilverlightEdit(CUITControls.SilverlightEdit sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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