using System.Collections.Generic;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.UITesting
{
    /// <summary>
    /// Browser window
    /// </summary>
    /// <seealso cref="CUITe.Controls.ControlBase{BrowserWindow}" />
    public class BrowserWindow : ControlBase<Microsoft.VisualStudio.TestTools.UITesting.BrowserWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserWindow"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public BrowserWindow(By searchConfiguration = null)
            : this(new Microsoft.VisualStudio.TestTools.UITesting.BrowserWindow(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserWindow"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public BrowserWindow(Microsoft.VisualStudio.TestTools.UITesting.BrowserWindow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the parent of the control.
        /// </summary>
        /// <exception cref="System.NotSupportedException"></exception>
        public override ControlBase Parent
        {
            get { throw new System.NotSupportedException(); }
        }

        /// <summary>
        /// Gets the previous sibling of the control.
        /// </summary>
        /// <exception cref="System.NotSupportedException"></exception>
        public override ControlBase PreviousSibling
        {
            get { throw new System.NotSupportedException(); }
        }

        /// <summary>
        /// Gets the next sibling of the control.
        /// </summary>
        /// <exception cref="System.NotSupportedException"></exception>
        public override ControlBase NextSibling
        {
            get { throw new System.NotSupportedException(); }
        }

        /// <summary>
        /// Gets the first child of the control.
        /// </summary>
        /// <exception cref="System.NotSupportedException"></exception>
        public override ControlBase FirstChild
        {
            get { throw new System.NotSupportedException(); }
        }

        /// <summary>
        /// Returns a sequence of all first level children of the control.
        /// </summary>
        /// <returns>The children.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public override IEnumerable<ControlBase> GetChildren()
        {
            throw new System.NotSupportedException();
        }
    }
}
