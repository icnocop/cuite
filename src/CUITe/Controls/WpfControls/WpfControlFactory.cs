using System;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Factory class for creating CUITe_Wpf* controls. Inherits from CUITe_ControlBaseFactory
    /// </summary>
    public class WpfControlFactory : CUITe_ControlBaseFactory
    {
        /// <summary>
        /// Create a CUITe_Wpf* control based on the type of provided WpfControl.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static ICUITe_ControlBase Create(Microsoft.VisualStudio.TestTools.UITesting.WpfControls.WpfControl control)
        {
            string CUITePrefix = ".CUITe_";
            string controlTypeName = control.GetType().Name;
            string CUITeNamespace = typeof(WpfControlFactory).Namespace;

            // Get CUITe type based on WpfControl type and namespace
            Type CUITeType = Type.GetType(CUITeNamespace + CUITePrefix + controlTypeName);

            // The type will be null if it does not exist
            if (CUITeType == null)
            {
                throw new Exception(string.Format("Control Type '{0}' not supported", control.GetType().Name));
            }

            // Create CUITe control
            ICUITe_ControlBase CUITeControl = (ICUITe_ControlBase)Activator.CreateInstance(CUITeType);

            // Wrap WinControl
            CUITeControl.WrapReady(control);

            return CUITeControl;
        }
    }
}
