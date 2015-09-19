using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a menu bar control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinMenuBar : WinControl<CUITControls.WinMenuBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinMenuBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinMenuBar(By searchConfiguration = null)
            : this(new CUITControls.WinMenuBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinMenuBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinMenuBar(CUITControls.WinMenuBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the collection of all items on the menu bar.
        /// </summary>
        public IEnumerable<WinMenuItem> Items
        {
            get
            {
                return SourceControl.Items
                    .Cast<CUITControls.WinMenuItem>()
                    .Select(item => new WinMenuItem(item))
                    .ToArray();
            }
        }
    }
}