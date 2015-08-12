#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightDatePicker.
    /// </summary>
    public class SilverlightDatePicker : SilverlightControl<CUIT.SilverlightDatePicker>
    {
        public SilverlightDatePicker() : base() { }
        public SilverlightDatePicker(string searchParameters) : base(searchParameters) { }
    }
}
#endif