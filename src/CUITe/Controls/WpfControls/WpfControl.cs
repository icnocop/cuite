using System;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Base wrapper class for all CUITe WPF controls, inherits from ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI WpfControl type</typeparam>
    public class WpfControl<T> : ControlBase<T> where T : CUITControls.WpfControl
    {
        public WpfControl()
        {
        }

        public WpfControl(string searchParameters)
            : base(searchParameters)
        {
        }

        /// <summary>
        /// Gets the parent of the current CUITe control.
        /// </summary>
        public override IControlBase Parent
        {
            get
            {
                SourceControl.WaitForControlReady();
                
                IControlBase ret = null;
                
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
            get { return UnWrap().AcceleratorKey; }
        }

        /// <summary>
        /// Wrap AccessKey property common to all WPF controls
        /// </summary>
        public string AccessKey
        {
            get { return UnWrap().AccessKey; }
        }

        /// <summary>
        /// Wrap AutomationId property common to all WPF controls
        /// </summary>
        public string AutomationId
        {
            get { return UnWrap().AutomationId; }
        }

        /// <summary>
        /// Wrap Font property common to all WPF controls
        /// </summary>
        public string Font
        {
            get { return UnWrap().Font; }
        }

        /// <summary>
        /// Wrap HelpText property common to all WPF controls
        /// </summary>
        public string HelpText
        {
            get { return UnWrap().HelpText; }
        }

        /// <summary>
        /// Wrap LabeledBy property common to all WPF controls
        /// </summary>
        public string LabeledBy
        {
            get { return UnWrap().LabeledBy; }
        }
    }
}
