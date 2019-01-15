using System;
using CUITe.PageObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITWinWindow = Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow;
using CUITWpfWindow = Microsoft.VisualStudio.TestTools.UITesting.WpfControls.WpfWindow;

namespace CUITe.ScreenObjects
{
    /// <summary>
    /// Abstract class representing a screen or window object in a WPF or WinForms
    /// application.
    /// </summary>
    /// <remarks>
    /// A <see cref="Screen"/> with a overwhelming number of controls can be split into logical
    /// screen objects, thus providing better test code maintainability.
    /// </remarks>
    /// <seealso cref="Screen"/>
    /// <seealso cref="ScreenObject{T}"/>
    public abstract class ScreenObject : ViewObject
    {
        private ApplicationUnderTest application;

        /// <summary>
        /// Gets the application.
        /// </summary>
        public ApplicationUnderTest Application
        {
            get { return application; }
            internal set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                application = value;
            }
        }
        
        /// <summary>
        /// Gets the screen object of specified type.
        /// </summary>
        /// <remarks>
        /// A <see cref="Screen"/> with a overwhelming number of controls can be split into logical
        /// screen objects, thus providing better test code maintainability.
        /// </remarks>
        /// <typeparam name="T">The type of the screen object.</typeparam>
        /// <returns>The screen object of specified type.</returns>
        protected T GetScreenObject<T>() where T : ScreenObject, new()
        {
            return new T
            {
                Application = Application,
                SearchLimitContainer = SearchLimitContainer
            };
        }

        /// <summary>
        /// Navigates to a new screen.
        /// </summary>
        /// <typeparam name="T">The type of screen to navigate to.</typeparam>
        /// <param name="title">The title of the screen.</param>
        /// <returns>The new screen.</returns>
        protected T NavigateTo<T>(string title) where T : Screen, new()
        {
            if (title == null)
                throw new ArgumentNullException("title");

            UITestControl searchLimitContainer;

            switch (Application.TechnologyName)
            {
                case "MSAA":
                    searchLimitContainer = new CUITWinWindow();
                    break;

                case "UIA":
                    searchLimitContainer = new CUITWpfWindow();
                    break;

                default:
                    throw new NotSupportedException(string.Format("Technology {0} is not supported.", Application.TechnologyName));
            }

            searchLimitContainer.SearchProperties[UITestControl.PropertyNames.Name] = title;
            searchLimitContainer.WindowTitles.Add(title);

            return new T
            {
                Application = Application,
                SearchLimitContainer = searchLimitContainer
            };
        }
    }
}