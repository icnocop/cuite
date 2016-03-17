using System;
using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Base class for all test controls in the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    /// <typeparam name="T">The source control type.</typeparam>
    public abstract class WpfControl<T> : ControlBase<T> where T : CUITControls.WpfControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfControl{T}"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
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
                WaitForControlReadyIfNecessary();
                
                try
                {
                    return ControlBaseFactory.Create(SourceControl.GetParent());
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).Parent", SourceControl.GetType().Name));
                }
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
        /// Gets the shortcut key that is assigned to this control.
        /// </summary>
        public string AcceleratorKey
        {
            get { return SourceControl.AcceleratorKey; }
        }

        /// <summary>
        /// Gets the keyboard shortcut that is assigned to this control.
        /// </summary>
        public string AccessKey
        {
            get { return SourceControl.AccessKey; }
        }

        /// <summary>
        /// Gets the automation ID that is assigned to this control.
        /// </summary>
        public string AutomationId
        {
            get { return SourceControl.AutomationId; }
        }

        /// <summary>
        /// Gets the name of the font for textual parts of this control.
        /// </summary>
        public string Font
        {
            get { return SourceControl.Font; }
        }

        /// <summary>
        /// Gets the help text that is assigned to this control.
        /// </summary>
        public string HelpText
        {
            get { return SourceControl.HelpText; }
        }

        /// <summary>
        /// Gets the label text of this control.
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
