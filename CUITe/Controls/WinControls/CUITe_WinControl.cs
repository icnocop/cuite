using System;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Factory class for creating CUITe_Win* controls. Inherits from CUITe_ControlBaseFactory
    /// </summary>
    public class CUITe_WinControlFactory : CUITe_ControlBaseFactory
    {
        /// <summary>
        /// Create a CUITe_Win* control based on the type of provided WinControl.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static ICUITe_ControlBase Create(WinControl control)
        {
            string CUITePrefix = ".CUITe_";
            string controlTypeName = control.GetType().Name;
            string CUITeNamespace = typeof(CUITe_WinControlFactory).Namespace;

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

    /// <summary>
    /// Base wrapper class for all CUITe_Win* controls, inherits from CUITe_ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI WinControl type</typeparam>
    public class CUITe_WinControl<T> : CUITe_ControlBase<T> where T : WinControl
    {
        public CUITe_WinControl() : base() { }
        public CUITe_WinControl(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the parent of the current CUITe control.
        /// </summary>
        public override ICUITe_ControlBase Parent
        {
            get
            {
                this._control.WaitForControlReady();
                
                ICUITe_ControlBase ret = null;
                
                try
                {
                    ret = CUITe_WinControlFactory.Create((WinControl)this._control.GetParent());
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new CUITe_InvalidTraversal(string.Format("({0}).Parent", this._control.GetType().Name));
                }
                return ret;
            }
        }
    }
}
