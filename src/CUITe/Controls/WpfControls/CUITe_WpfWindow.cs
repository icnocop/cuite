using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfWindow
    /// </summary>
    public class CUITe_WpfWindow : CUITe_WpfControl<WpfWindow>
    {
        public CUITe_WpfWindow() : base() { }

        public CUITe_WpfWindow(string searchParameters) : base(searchParameters) 
        {
            WpfWindow baseControl = new WpfWindow();
            this.Wrap(baseControl);
        }

        #region Properties

        public bool AlwaysOnTop
        {
            get { return this.UnWrap().AlwaysOnTop; }
        }

        public bool HasTitleBar
        {
            get { return this.UnWrap().HasTitleBar; }
        }

        public bool Maximized
        {
            get { return this.UnWrap().Maximized; }
            set { this.UnWrap().Maximized = value; }
        }

        public bool Minimized
        {
            get { return this.UnWrap().Minimized; }
            set { this.UnWrap().Minimized = value; }
        }

        public bool Popup
        {
            get { return this.UnWrap().Popup; }
        }

        public bool Resizable
        {
            get { return this.UnWrap().Resizable; }
        }

        public bool Restored
        {
            get { return this.UnWrap().Restored; }
            set { this.UnWrap().Restored = value; }
        }

        public bool ShowInTaskbar
        {
            get { return this.UnWrap().ShowInTaskbar; }
        }

        public bool TabStop
        {
            get { return this.UnWrap().TabStop; }
        }

        public bool Transparent
        {
            get { return this.UnWrap().Transparent; }
        }

        #endregion

    }
}