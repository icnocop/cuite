using System;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Factory capable of creating WinForms UI test controls inheriting from
    /// <see cref="ControlBase"/>.
    /// </summary>
    internal class WinControlFactory : ControlBaseFactory
    {
        /// <summary>
        /// Creates a UI test control based on specified <see cref="CUITControls.WinControl"/>.
        /// </summary>
        /// <param name="sourceControl">The source control to base the UI test control on.</param>
        /// <returns>
        /// A UI test control based on specified <see cref="CUITControls.WinControl"/>.
        /// </returns>
        internal static ControlBase Create(CUITControls.WinControl sourceControl)
        {
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");

            string targetNamespace = typeof(WinControlFactory).Namespace;
            return Create(sourceControl, targetNamespace);
        }
    }
}