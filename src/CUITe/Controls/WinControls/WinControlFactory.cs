using System;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Factory class for creating CUITe_Win* controls. Inherits from CUITe_ControlBaseFactory
    /// </summary>
    public class WinControlFactory : CUITe_ControlBaseFactory
    {
        /// <summary>
        /// Create a CUITe_Win* control based on the type of provided WinControl.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static ICUITe_ControlBase Create(CUIT.WinControl control)
        {
            string CUITePrefix = ".CUITe_";
            string controlTypeName = control.GetType().Name;
            string CUITeNamespace = typeof(WinControlFactory).Namespace;

            // Get CUITe type based on WinControl type and namespace
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
