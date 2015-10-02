using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Mappings
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
        {
            SearchLimitContainer = searchLimitContainer;
        }

        /// <summary>
        /// Gets the page component of specified type.
        /// </summary>
        /// <remarks>
        /// A <see cref="Page"/> with a overwhelming number of controls can be split into logical
        /// components, thus providing better test code maintainability.
        /// </remarks>
        /// <typeparam name="T">The type of the page component.</typeparam>
        /// <returns>The page component of specified type.</returns>
        protected T GetComponent<T>() where T : PageComponent, new()
        {
            return new T
            {
                SearchLimitContainer = SearchLimitContainer
            };
        }
    }
}