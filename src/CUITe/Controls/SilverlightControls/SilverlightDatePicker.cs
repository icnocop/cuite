#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightDatePicker.
    /// </summary>
    public class SilverlightDatePicker : SilverlightControl<CUITControls.SilverlightDatePicker>
    {
        public SilverlightDatePicker(By searchConfiguration = null)
            : this(new CUITControls.SilverlightDatePicker(), searchConfiguration)
        {
        }

        public SilverlightDatePicker(CUITControls.SilverlightDatePicker sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif