using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ObjectRepository
{
    /// <summary>
    /// Abstract class representing a screen or a window in a WPF or WinForms application.
    /// </summary>
    public abstract class Screen : ScreenComponent
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
    }
}