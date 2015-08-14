#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightDatePicker.
    /// </summary>
    public class SilverlightDatePicker : SilverlightControl<CUITControls.SilverlightDatePicker>
    {
        public SilverlightDatePicker() { }
        public SilverlightDatePicker(string searchParameters) : base(searchParameters) { }
    }
}
#endif