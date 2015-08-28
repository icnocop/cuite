using System;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Base wrapper class for all CUITe WPF controls, inherits from ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI WpfControl type</typeparam>
    public abstract class WpfControl<T> : ControlBase<T> where T : CUITControls.WpfControl
    {
        protected WpfControl(T sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        /// <summary>
        /// Gets the parent of the current CUITe control.
        /// </summary>
        public override ControlBase Parent
        {
            get
            {
                WaitForControlReady();
                
                ControlBase ret = null;
                
                try
                {
                    ret = WpfControlFactory.Create((CUITControls.WpfControl)SourceControl.GetParent());
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).Parent", SourceControl.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Wrap AcceleratorKey property common to all WPF controls
        /// </summary>
        public string AcceleratorKey
        {
            get { return SourceControl.AcceleratorKey; }
        }

        /// <summary>
        /// Wrap AccessKey property common to all WPF controls
        /// </summary>
        public string AccessKey
        {
            get { return SourceControl.AccessKey; }
        }

        /// <summary>
        /// Wrap AutomationId property common to all WPF controls
        /// </summary>
        public string AutomationId
        {
            get { return SourceControl.AutomationId; }
        }

        /// <summary>
        /// Wrap Font property common to all WPF controls
        /// </summary>
        public string Font
        {
            get { return SourceControl.Font; }
        }

        /// <summary>
        /// Wrap HelpText property common to all WPF controls
        /// </summary>
        public string HelpText
        {
            get { return SourceControl.HelpText; }
        }

        /// <summary>
        /// Wrap LabeledBy property common to all WPF controls
        /// </summary>
        public string LabeledBy
        {
            get { return SourceControl.LabeledBy; }
        }
    }
}
