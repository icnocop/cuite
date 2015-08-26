using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls
{
    /// <summary>
    /// Factory capable of creating UI test controls inheriting from <see cref="IControlBase"/>.
    /// </summary>
    internal class ControlBaseFactory
    {
        /// <summary>
        /// Creates a UI test control of type <see cref="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the UI test control to create.</typeparam>
        /// <returns>A UI test control of type <see cref="T"/>.</returns>
        internal static T Create<T>() where T : IControlBase
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        /// <summary>
        /// Creates a UI test control of type <see cref="T"/> with specified search properties.
        /// </summary>
        /// <typeparam name="T">The type of the UI test control to create.</typeparam>
        /// <param name="searchProperties">The search properties.</param>
        /// <returns>
        /// A UI test control of type <see cref="T"/> with specified search properties.
        /// </returns>
        internal static T Create<T>(string searchProperties) where T : IControlBase
        {
            return (T)Activator.CreateInstance(typeof(T), searchProperties);
        }

        protected static IControlBase Create(UITestControl sourceControl, string targetNamespace)
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
            var control = (IControlBase)Activator.CreateInstance(targetType);

            // Wrap WinControl
            control.WrapReady(sourceControl);

            return control;
        }
    }
}