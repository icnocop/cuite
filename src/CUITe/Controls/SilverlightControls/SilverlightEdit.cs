#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit.
    /// </summary>
    public class SilverlightEdit : SilverlightControl<CUITControls.SilverlightEdit>
    {
        public SilverlightEdit(By searchConfiguration = null)
            : this(new CUITControls.SilverlightEdit(), searchConfiguration)
        {
        }

        public SilverlightEdit(CUITControls.SilverlightEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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