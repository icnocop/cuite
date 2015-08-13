using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Factory class for creating CUITe WPF controls. Inherits from ControlBaseFactory
    /// </summary>
    public class WpfControlFactory : ControlBaseFactory
    {
        /// <summary>
        /// Create a CUITe WPF control based on the type of provided WpfControl.
        /// </summary>
        /// <param name="sourceControl"></param>
        /// <returns></returns>
        public static IControlBase Create(CUITControls.WpfControl sourceControl)
        {
            string targetNamespace = typeof(WpfControlFactory).Namespace;
            return Create(sourceControl, targetNamespace);
        }
    }
}