using System.Collections.Generic;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.UITesting
{
    /// <summary>
    /// Application Under Test
    /// </summary>
    /// <seealso cref="CUITe.Controls.ControlBase{ApplicationUnderTest}" />
    public class ApplicationUnderTest : ControlBase<Microsoft.VisualStudio.TestTools.UITesting.ApplicationUnderTest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUnderTest"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public ApplicationUnderTest(By searchConfiguration = null)
            : this(new Microsoft.VisualStudio.TestTools.UITesting.ApplicationUnderTest(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUnderTest"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public ApplicationUnderTest(Microsoft.VisualStudio.TestTools.UITesting.ApplicationUnderTest sourceControl, By searchConfiguration = null)
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
