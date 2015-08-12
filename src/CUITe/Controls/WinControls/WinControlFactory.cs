using System;
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
        /// <param name="control"></param>
        /// <returns></returns>
        public static IControlBase Create(CUITControls.WinControl control)
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
            IControlBase cuiteControl = (IControlBase)Activator.CreateInstance(CUITeType);

            // Wrap WinControl
            cuiteControl.WrapReady(control);

            return cuiteControl;
        }
    }
}
