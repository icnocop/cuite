using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinWindow
    /// </summary>
    public class WinWindow : WinControl<CUITControls.WinWindow>
    {
        public WinWindow()
        {
        }

        public WinWindow(string searchParameters)
            : base(searchParameters)
        {
            var baseControl = new CUITControls.WinWindow();
            Wrap(baseControl);
        }

        public bool AlwaysOnTop
        {
            get { return UnWrap().AlwaysOnTop; }
        }

        public bool HasTitleBar
        {
            get { return UnWrap().HasTitleBar; }
        }

        public bool Maximized
        {
            get { return UnWrap().Maximized; }
            set { UnWrap().Maximized = value; }
        }

        public bool Minimized
        {
            get { return UnWrap().Minimized; }
            set { UnWrap().Minimized = value; }
        }

        public int OrderOfInvocation
        {
            get { return UnWrap().OrderOfInvocation; }
        }

        public bool Popup
        {
            get { return UnWrap().Popup; }
        }

        public bool Resizable
        {
            get { return UnWrap().Resizable; }
        }

        public bool Restored
        {
            get { return UnWrap().Restored; }
            set { UnWrap().Restored = value; }
        }

        public bool ShowInTaskbar
        {
            get { return UnWrap().ShowInTaskbar; }
        }

        public bool TabStop
        {
            get { return UnWrap().TabStop; }
        }

        public bool Transparent
        {
            get { return UnWrap().Transparent; }
        }
    }
}