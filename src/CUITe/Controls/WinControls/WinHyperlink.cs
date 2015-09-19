using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a Windows hyperlink control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinHyperlink : WinControl<CUITControls.WinHyperlink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinHyperlink"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinHyperlink(By searchConfiguration = null)
            : this(new CUITControls.WinHyperlink(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinHyperlink"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinHyperlink(CUITControls.WinHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the display text for this hyperlink control.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}