using System.Windows.Forms;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a calendar control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinCalendar : WinControl<CUITControls.WinCalendar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinCalendar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCalendar(By searchConfiguration = null)
            : this(new CUITControls.WinCalendar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinCalendar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCalendar(CUITControls.WinCalendar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="SelectionRange"/> for this calendar control.
        /// </summary>
        public SelectionRange SelectionRange
        {
            get { return SourceControl.SelectionRange; }
            set { SourceControl.SelectionRange = value; }
        }

        /// <summary>
        /// Gets or sets the value of the <see cref="SelectionRange"/> property as a string.
        /// </summary>
        public string SelectionRangeAsString
        {
            get { return SourceControl.SelectionRangeAsString; }
            set { SourceControl.SelectionRangeAsString = value; }
        }
    }
}