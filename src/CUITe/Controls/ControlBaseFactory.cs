using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls
{
    /// <summary>
    /// Factory class for creating CUITe objects
    /// </summary>
    public class ControlBaseFactory
    {
        public static T Create<T>(string searchProperties) where T : IControlBase
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

            // Create CUITe control
            var cuiteControl = (IControlBase)Activator.CreateInstance(targetType);

            // Wrap WinControl
            cuiteControl.WrapReady(sourceControl);

            return cuiteControl;
        }
    }
}