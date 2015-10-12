using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ObjectRepository
{
    /// <summary>
    /// Abstract class representing a page in a HTML application.
    /// </summary>
    public abstract class Page : PageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Page"/> class.
        /// </summary>
        /// <param name="searchLimitContainer">Container for locating controls.</param>
        protected Page(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }
    }
}