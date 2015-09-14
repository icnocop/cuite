using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents an image control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfImage : WpfControl<CUITControls.WpfImage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfImage"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfImage(By searchConfiguration = null)
            : this(new CUITControls.WpfImage(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfImage"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfImage(CUITControls.WpfImage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the alternate text for this image control.
        /// </summary>
        public string Alt
        {
            get { return SourceControl.Alt; }
        }
    }
}