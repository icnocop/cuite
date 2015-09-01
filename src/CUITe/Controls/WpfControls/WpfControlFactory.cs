using System;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Factory capable of creating WPF UI test controls inheriting from
    /// <see cref="ControlBase"/>.
    /// </summary>
    internal class WpfControlFactory : ControlBaseFactory
    {
        /// <summary>
        /// Creates a UI test control based on specified <see cref="CUITControls.WpfControl"/>.
        /// </summary>
        /// <param name="sourceControl">The source control to base the UI test control on.</param>
        /// <returns>
        /// A UI test control based on specified <see cref="CUITControls.WpfControl"/>.
        /// </returns>
        internal static ControlBase Create(CUITControls.WpfControl sourceControl)
        {
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");

            string targetNamespace = typeof(WpfControlFactory).Namespace;
            return Create(sourceControl, targetNamespace);
        }
    }
}