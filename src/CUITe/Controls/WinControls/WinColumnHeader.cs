using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// WRepresents a button control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinColumnHeader : WinControl<CUITControls.WinColumnHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinColumnHeader"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinColumnHeader(By searchConfiguration = null)
            : this(new CUITControls.WinColumnHeader(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinColumnHeader"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinColumnHeader(CUITControls.WinColumnHeader sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}