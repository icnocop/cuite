using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a window control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfWindow : WpfControl<CUITControls.WpfWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfWindow"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfWindow(By searchConfiguration = null)
            : this(new CUITControls.WpfWindow(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfWindow"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfWindow(CUITControls.WpfWindow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a value that indicates whether this window must always be on top.
        /// </summary>
        public bool AlwaysOnTop
        {
            get { return SourceControl.AlwaysOnTop; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window has a title bar.
        /// </summary>
        public bool HasTitleBar
        {
            get { return SourceControl.HasTitleBar; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window is maximized.
        /// </summary>
        public bool Maximized
        {
            get { return SourceControl.Maximized; }
            set { SourceControl.Maximized = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window is minimized.
        /// </summary>
        public bool Minimized
        {
            get { return SourceControl.Minimized; }
            set { SourceControl.Minimized = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window is a pop-up window.
        /// </summary>
        public bool Popup
        {
            get { return SourceControl.Popup; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window is resizable.
        /// </summary>
        public bool Resizable
        {
            get { return SourceControl.Resizable; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window has been restored.
        /// </summary>
        public bool Restored
        {
            get { return SourceControl.Restored; }
            set { SourceControl.Restored = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window appears in the task bar.
        /// </summary>
        public bool ShowInTaskbar
        {
            get { return SourceControl.ShowInTaskbar; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window is a tab stop.
        /// </summary>
        public bool TabStop
        {
            get { return SourceControl.TabStop; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window is transparent.
        /// </summary>
        public bool Transparent
        {
            get { return SourceControl.Transparent; }
        }
    }
}