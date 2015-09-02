using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

#if SILVERLIGHT_SUPPORT
namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightRadioButton.
    /// </summary>
    public class SilverlightRadioButton : SilverlightControl<CUITControls.SilverlightRadioButton>
    {
        public SilverlightRadioButton(By searchConfiguration = null)
            : this(new CUITControls.SilverlightRadioButton(), searchConfiguration)
        {
        }

        public SilverlightRadioButton(CUITControls.SilverlightRadioButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public void Select()
        {
            WaitForControlReady();
            SourceControl.Selected = true;
        }

        public bool IsSelected
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Selected;
            }
        }
    }
}
#endif