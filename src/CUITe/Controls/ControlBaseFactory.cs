using System;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls
{
    /// <summary>
    /// Factory capable of creating UI test controls inheriting from <see cref="ControlBase"/>.
    /// </summary>
    internal class ControlBaseFactory
    {
        /// <summary>
        /// Creates a UI test control of type <see cref="T"/> with specified search configuration.
        /// </summary>
        /// <typeparam name="T">The type of the UI test control to create.</typeparam>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <returns>
        /// A UI test control of type <see cref="T"/> with specified search configuration.
        /// </returns>
        internal static T Create<T>(By searchConfiguration) where T : ControlBase
        {
            return (T)Create(typeof(T), searchConfiguration);
        }

        /// <summary>
        /// Creates a UI test control of type <paramref name="controlType"/> with specified search
        /// properties.
        /// </summary>
        /// <param name="controlType">The type of the UI test control to create.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <returns>
        /// A UI test control of type <paramref name="controlType"/> with specified search configuration.
        /// </returns>
        internal static ControlBase Create(Type controlType, By searchConfiguration)
        {
            if (controlType == null)
                throw new ArgumentNullException("controlType");

            try
            {
                return (ControlBase)Activator.CreateInstance(controlType, searchConfiguration);
            }
            catch (MissingMethodException)
            {
                string message = string.Format(
                    "No constructor for type '{0}' contains arguments in the following order:" + Environment.NewLine +
                    "  1. By - Search configuration",
                    controlType);

                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Creates a UI test control of type <see cref="T"/> with specified source control and
        /// search configuration.
        /// </summary>
        /// <typeparam name="T">The type of the UI test control to create.</typeparam>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <returns>
        /// A UI test control of type <see cref="T"/> with specified source control and search
        /// properties.
        /// </returns>
        internal static T Create<T>(UITestControl sourceControl, By searchConfiguration) where T : ControlBase
        {
            return (T)Create(typeof(T), sourceControl, searchConfiguration);
        }

        /// <summary>
        /// Creates a UI test control of type <paramref name="controlType"/> with specified source
        /// control and search configuration.
        /// </summary>
        /// <param name="controlType">The type of the UI test control to create.</param>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <returns>
        /// A UI test control of type <see cref="controlType"/> with specified source control and
        /// search configuration.
        /// </returns>
        internal static ControlBase Create(Type controlType, UITestControl sourceControl, By searchConfiguration)
        {
            if (controlType == null)
                throw new ArgumentNullException("controlType");
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");

            try
            {
                return (ControlBase)Activator.CreateInstance(controlType, sourceControl, searchConfiguration);
            }
            catch (MissingMethodException)
            {
                string message = string.Format(
                    "No constructor for the type '{0}' contains arguments in the following order:" + Environment.NewLine +
                    "  1. Class that inherits from UITestControl - Source control" + Environment.NewLine +
                    "  2. By - Search configuration",
                    controlType);

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