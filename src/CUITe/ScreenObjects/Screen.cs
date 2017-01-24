using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ScreenObjects
{
    /// <summary>
    /// Abstract class representing a screen or a window in a WPF or WinForms application.
    /// </summary>
    /// <seealso cref="ScreenObject"/>
    /// <seealso cref="ScreenObject{T}"/>
    public abstract class Screen : ScreenObject
    {
        /// <summary>
        /// Launches application with specified path and returns a screen of type
        /// <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the screen to return.</typeparam>
        /// <param name="applicationPath">The path of the application to start.</param>
        /// <returns>A screen representing the launched application.</returns>
        public static T Launch<T>(string applicationPath) where T : Screen, new()
        {
            if (applicationPath == null)
                throw new ArgumentNullException("applicationPath");

            return Launch<T>(new ProcessStartInfo(applicationPath));
        }

        /// <summary>
        /// Launches application with specified process start information and returns a screen of
        /// type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the screen to return.</typeparam>
        /// <param name="applicationStartInfo">The application start information.</param>
        /// <returns>A screen representing the launched application.</returns>
        public static T Launch<T>(ProcessStartInfo applicationStartInfo) where T : Screen, new()
        {
            if (applicationStartInfo == null)
                throw new ArgumentNullException("applicationStartInfo");

            var application = ApplicationUnderTest.Launch(applicationStartInfo);

            return new T
            {
                Application = application,
                SearchLimitContainer = application
            };
        }


        /// <summary>
        /// Creates a reference to an application from an existing process and returns a screen of
        /// type <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">The type of the screen to return.</typeparam>
        /// <param name="processToWrap">The process to create from</param>
        /// <param name="title">The title.</param>
        /// <returns>
        /// A screen representing the launched application.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">processToWrap</exception>
        public static T FromProcess<T>(Process processToWrap, string title = null) where T : Screen, new()
        {
            if (processToWrap == null)
                throw new ArgumentNullException("processToWrap");

            var application = ApplicationUnderTest.FromProcess(processToWrap);

            if (!string.IsNullOrEmpty(title))
            {
                application.SearchProperties[UITestControl.PropertyNames.Name] = title;
                application.WindowTitles.Add(title);
            }

            return new T
            {
                Application = application,
                SearchLimitContainer = application
            };
        }
    }
}