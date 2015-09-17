using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a custom control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinCustom : WinControl<CUITControls.WinCustom>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinCustom"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCustom(By searchConfiguration = null)
            : this(new CUITControls.WinCustom(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinCustom"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCustom(CUITControls.WinCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}