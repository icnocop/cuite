using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a window control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinWindow : WinControl<CUITControls.WinWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinWindow"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinWindow(By searchConfiguration = null)
            : this(new CUITControls.WinWindow(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinWindow"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinWindow(CUITControls.WinWindow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a value that indicates whether this window always appears on top of other windows.
        /// </summary>
        public bool AlwaysOnTop
        {
            get { return SourceControl.AlwaysOnTop; }
        }

        /// <summary>
        /// Gets a value that indicates whether this window control has a title bar.
        /// </summary>
        public bool HasTitleBar
        {
            get { return SourceControl.HasTitleBar; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this window control is maximized.
        /// </summary>
        public bool Maximized
        {
            get { return SourceControl.Maximized; }
            set { SourceControl.Maximized = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this window control is minimized.
        /// </summary>
        public bool Minimized
        {
            get { return SourceControl.Minimized; }
            set { SourceControl.Minimized = value; }
        }

        /// <summary>
        /// Gets the order of invocation for this window.
        /// </summary>
        public int OrderOfInvocation
        {
            get { return SourceControl.OrderOfInvocation; }
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
        /// Gets or sets a value that indicates whether this window is restored.
        /// </summary>
        public bool Restored
        {
            get { return SourceControl.Restored; }
            set { SourceControl.Restored = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this window appears in the taskbar.
        /// </summary>
        public bool ShowInTaskbar
        {
            get { return SourceControl.ShowInTaskbar; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this window is a tab stop.
        /// </summary>
        public bool TabStop
        {
            get { return SourceControl.TabStop; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this window is transparent.
        /// </summary>
        public bool Transparent
        {
            get { return SourceControl.Transparent; }
        }
    }
}