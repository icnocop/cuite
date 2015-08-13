using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Factory class for creating CUITe WinForms controls. Inherits from ControlBaseFactory
    /// </summary>
    public class WinControlFactory : ControlBaseFactory
    {
        /// <summary>
        /// Create a CUITe WinForms control based on the type of provided WinControl.
        /// </summary>
        /// <param name="sourceControl"></param>
        /// <returns></returns>
        public static IControlBase Create(CUITControls.WinControl sourceControl)
        {
            string targetNamespace = typeof(WinControlFactory).Namespace;
            return Create(sourceControl, targetNamespace);
        }
    }
}