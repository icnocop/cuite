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
        {
            SearchLimitContainer = searchLimitContainer;
        }

        /// <summary>
        /// Gets the screen component of specified type.
        /// </summary>
        /// <remarks>
        /// A <see cref="Screen"/> with a overwhelming number of controls can be split into logical
        /// components, thus providing better test code maintainability.
        /// </remarks>
        /// <typeparam name="T">The type of the screen component.</typeparam>
        /// <returns>The screen component of specified type.</returns>
        protected T GetComponent<T>() where T : ScreenComponent, new()
        {
            return new T
            {
                SearchLimitContainer = SearchLimitContainer
            };
        }
    }
}