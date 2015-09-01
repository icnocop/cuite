#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightDatePicker.
    /// </summary>
    public class SilverlightDatePicker : SilverlightControl<CUITControls.SilverlightDatePicker>
    {
        public SilverlightDatePicker(string searchProperties = null)
            : this(new CUITControls.SilverlightDatePicker(), searchProperties)
        {
        }

        public SilverlightDatePicker(CUITControls.SilverlightDatePicker sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}
#endif