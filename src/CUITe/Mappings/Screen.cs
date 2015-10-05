using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Mappings
{
    /// <summary>
    /// Abstract class representing a screen or a window in a WPF or WinForms application.
    /// </summary>
    public abstract class Screen : ScreenComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Screen"/> class.
        /// </summary>
        /// <param name="searchLimitContainer">Container for locating controls.</param>
        protected Screen(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }
    }
}