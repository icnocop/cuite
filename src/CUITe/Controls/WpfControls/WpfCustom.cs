using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a custom control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfCustom : WpfControl<CUITControls.WpfCustom>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfCustom"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfCustom(By searchConfiguration = null)
            : this(new CUITControls.WpfCustom(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfCustom"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfCustom(CUITControls.WpfCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}