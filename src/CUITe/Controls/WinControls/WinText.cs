using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a text control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinText : WinControl<CUITControls.WinText>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinText"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinText(By searchConfiguration = null)
            : this(new CUITControls.WinText(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinText"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinText(CUITControls.WinText sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the display text of this text control.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}