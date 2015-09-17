using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a split button control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinSplitButton : WinControl<CUITControls.WinSplitButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinSplitButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinSplitButton(By searchConfiguration = null)
            : this(new CUITControls.WinSplitButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinSplitButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinSplitButton(CUITControls.WinSplitButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the text of this button.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        /// <summary>
        /// Gets the shortcut for this button.
        /// </summary>
        public string Shortcut
        {
            get { return SourceControl.Shortcut; }
        }
    }
}