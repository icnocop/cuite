using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls
{
    /// <summary>
    /// Factory capable of creating UI test controls inheriting from <see cref="ControlBase"/>.
    /// </summary>
    internal class ControlBaseFactory
    {
        /// <summary>
        /// Creates a UI test control of type <see cref="T"/> with specified search properties.
        /// </summary>
        /// <typeparam name="T">The type of the UI test control to create.</typeparam>
        /// <param name="searchProperties">The search properties.</param>
        /// <returns>
        /// A UI test control of type <see cref="T"/> with specified search properties.
        /// </returns>
        internal static T Create<T>(string searchProperties) where T : ControlBase
        {
            try
            {
                return (T)Activator.CreateInstance(typeof(T), searchProperties);
            }
            catch (MissingMethodException)
            {
                string message = string.Format(
                    "No constructor for type '{0}' contains arguments in the following order:" + Environment.NewLine +
                    "  1. String - Search properties",
                    typeof(T));

                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Creates a UI test control of type <see cref="T"/> with specified source control and
        /// search properties.
        /// </summary>
        /// <typeparam name="T">The type of the UI test control to create.</typeparam>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchProperties">The search properties.</param>
        /// <returns>
        /// A UI test control of type <see cref="T"/> with specified source control and search
        /// properties.
        /// </returns>
        internal static T Create<T>(UITestControl sourceControl, string searchProperties) where T : ControlBase
        {
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");

            try
            {
                return (T)Activator.CreateInstance(typeof(T), sourceControl, searchProperties);
            }
            catch (MissingMethodException)
            {
                string message = string.Format(
                    "No constructor for the type '{0}' contains arguments in the following order:" + Environment.NewLine +
                    "  1. Class that inherits from UITestControl - Source control" + Environment.NewLine +
                    "  2. String - Search properties",
                    typeof(T));

                throw new ArgumentException(message);
            }
        }

        protected static ControlBase Create(UITestControl sourceControl, string targetNamespace)
        {
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");
            if (targetNamespace == null)
                throw new ArgumentNullException("targetNamespace");

            string targetName = sourceControl.GetType().Name;
            string typeFullName = string.Format("{0}.{1}", targetNamespace, targetName);
            Type targetType = Type.GetType(typeFullName);

            // The type will be null if it does not exist
            if (targetType == null)
            {
                throw new ArgumentException(
                    string.Format("Control of type '{0}' is not supported.", sourceControl.GetType().Name),
                    "sourceControl");
            }

            // Create UI test control
            return (ControlBase)Activator.CreateInstance(targetType, sourceControl);
        }
    }
}