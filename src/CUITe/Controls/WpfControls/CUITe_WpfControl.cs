using System;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Factory class for creating CUITe_Wpf* controls. Inherits from CUITe_ControlBaseFactory
    /// </summary>
    public class CUITe_WpfControlFactory : CUITe_ControlBaseFactory
    {
        /// <summary>
        /// Create a CUITe_Wpf* control based on the type of provided WpfControl.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static ICUITe_ControlBase Create(WpfControl control)
        {
            string CUITePrefix = ".CUITe_";
            string controlTypeName = control.GetType().Name;
            string CUITeNamespace = typeof(CUITe_WpfControlFactory).Namespace;

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

    /// <summary>
    /// Base wrapper class for all CUITe_Wpf* controls, inherits from CUITe_ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI WpfControl type</typeparam>
    public class CUITe_WpfControl<T> : CUITe_ControlBase<T> where T : WpfControl
    {
        public CUITe_WpfControl() : base() { }
        public CUITe_WpfControl(string searchParameters) : base(searchParameters) { }

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
                    ret = CUITe_WpfControlFactory.Create((WpfControl)this._control.GetParent());
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new CUITe_InvalidTraversal(string.Format("({0}).Parent", this._control.GetType().Name));
                }
                return ret;
            }
        }


        /// <summary>
        /// Wrap AcceleratorKey property common to all WPF controls
        /// </summary>
        public string AcceleratorKey
        {
            get { return this.UnWrap().AcceleratorKey; }
        }

        /// <summary>
        /// Wrap AccessKey property common to all WPF controls
        /// </summary>
        public string AccessKey
        {
            get { return this.UnWrap().AccessKey; }
        }

        /// <summary>
        /// Wrap AutomationId property common to all WPF controls
        /// </summary>
        public string AutomationId
        {
            get { return this.UnWrap().AutomationId; }
        }

        /// <summary>
        /// Wrap Font property common to all WPF controls
        /// </summary>
        public string Font
        {
            get { return this.UnWrap().Font; }
        }

        /// <summary>
        /// Wrap HelpText property common to all WPF controls
        /// </summary>
        public string HelpText
        {
            get { return this.UnWrap().HelpText; }
        }

        /// <summary>
        /// Wrap LabeledBy property common to all WPF controls
        /// </summary>
        public string LabeledBy
        {
            get { return this.UnWrap().LabeledBy; }
        }
    }
}
