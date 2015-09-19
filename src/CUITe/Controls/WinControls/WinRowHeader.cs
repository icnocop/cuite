using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a row header control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinRowHeader : WinControl<CUITControls.WinRowHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinRowHeader"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinRowHeader(By searchConfiguration = null)
            : this(new CUITControls.WinRowHeader(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinRowHeader"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinRowHeader(CUITControls.WinRowHeader sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a value that indicates whether this row header control is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
        }
    }
}