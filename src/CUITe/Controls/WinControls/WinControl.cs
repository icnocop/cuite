using System;
using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Base class for all test controls in the user interface (UI) of Windows Forms.
    /// </summary>
    /// <typeparam name="T">The source control type.</typeparam>
    public abstract class WinControl<T> : ControlBase<T> where T : CUITControls.WinControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinControl{T}"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        protected WinControl(T sourceControl, By searchConfiguration = null)
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

                try
                {
                    return WinControlFactory.Create((CUITControls.WinControl)SourceControl.GetParent());
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
        /// Returns a sequence of all first level children of the control.
        /// </summary>
        public override IEnumerable<ControlBase> GetChildren()
        {
            return Enumerable.Empty<ControlBase>();
        }
    }
}