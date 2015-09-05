using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinWindow
    /// </summary>
    public class WinWindow : WinControl<CUITControls.WinWindow>
    {
        public WinWindow(By searchConfiguration = null)
            : this(new CUITControls.WinWindow(), searchConfiguration)
        {
        }

        public WinWindow(CUITControls.WinWindow sourceControl, By searchConfiguration = null)
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

        public int OrderOfInvocation
        {
            get { return SourceControl.OrderOfInvocation; }
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