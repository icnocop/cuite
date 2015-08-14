using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfWindow
    /// </summary>
    public class WpfWindow : WpfControl<CUITControls.WpfWindow>
    {
        public WpfWindow()
        {
        }

        public WpfWindow(string searchParameters)
            : base(searchParameters)
        {
            var baseControl = new CUITControls.WpfWindow();
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