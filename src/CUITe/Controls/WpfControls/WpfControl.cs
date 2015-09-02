using System;
using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Base wrapper class for all CUITe WPF controls, inherits from ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI WpfControl type</typeparam>
    public abstract class WpfControl<T> : ControlBase<T> where T : CUITControls.WpfControl
    {
        protected WpfControl(T sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the parent of the control.
        /// </summary>
        /// <exception cref="InvalidTraversalException">
        /// Error occurred when traversing the control tree.
        /// </exception>
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
        /// Gets the previous sibling of the control.
        /// </summary>
        /// <exception cref="InvalidTraversalException">
        /// Error occurred when traversing the control tree.
        /// </exception>
        public override ControlBase PreviousSibling
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the next sibling of the control.
        /// </summary>
        /// <exception cref="InvalidTraversalException">
        /// Error occurred when traversing the control tree.
        /// </exception>
        public override ControlBase NextSibling
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the first child of the control.
        /// </summary>
        /// <exception cref="InvalidTraversalException">
        /// Error occurred when traversing the control tree.
        /// </exception>
        public override ControlBase FirstChild
        {
            get { return null; }
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

        /// <summary>
        /// Returns a sequence of all first level children of the control.
        /// </summary>
        public override IEnumerable<ControlBase> GetChildren()
        {
            return Enumerable.Empty<ControlBase>();
        }
    }
}
