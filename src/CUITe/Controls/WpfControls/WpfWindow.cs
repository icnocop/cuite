using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfWindow
    /// </summary>
    public class WpfWindow : WpfControl<CUITControls.WpfWindow>
    {
        public WpfWindow(By searchConfiguration = null)
            : this(new CUITControls.WpfWindow(), searchConfiguration)
        {
        }

        public WpfWindow(CUITControls.WpfWindow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public bool AlwaysOnTop
        {
            get { return SourceControl.AlwaysOnTop; }
        }

        public bool HasTitleBar
        {
            get { return SourceControl.HasTitleBar; }
        }

        public bool Maximized
        {
            get { return SourceControl.Maximized; }
            set { SourceControl.Maximized = value; }
        }

        public bool Minimized
        {
            get { return SourceControl.Minimized; }
            set { SourceControl.Minimized = value; }
        }

        public bool Popup
        {
            get { return SourceControl.Popup; }
        }

        public bool Resizable
        {
            get { return SourceControl.Resizable; }
        }

        public bool Restored
        {
            get { return SourceControl.Restored; }
            set { SourceControl.Restored = value; }
        }

        public bool ShowInTaskbar
        {
            get { return SourceControl.ShowInTaskbar; }
        }

        public bool TabStop
        {
            get { return SourceControl.TabStop; }
        }

        public bool Transparent
        {
            get { return SourceControl.Transparent; }
        }
    }
}