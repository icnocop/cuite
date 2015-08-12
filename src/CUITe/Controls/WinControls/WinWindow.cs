using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinWindow
    /// </summary>
    public class WinWindow : WinControl<CUIT.WinWindow>
    {
        public WinWindow() : base() { }
        
        public WinWindow(string searchParameters) : base(searchParameters) 
        {
            var baseControl = new CUIT.WinWindow();
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

        public int OrderOfInvocation
        {
            get { return this.UnWrap().OrderOfInvocation; }
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
