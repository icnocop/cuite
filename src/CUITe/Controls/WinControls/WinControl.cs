using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinControl : WinControl<CUITControls.WinControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinControl"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinControl(By searchConfiguration = null)
            : this(new CUITControls.WinControl(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinControl"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinControl(CUITControls.WinControl sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}