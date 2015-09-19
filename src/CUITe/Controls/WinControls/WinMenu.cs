using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a menu control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinMenu : WinControl<CUITControls.WinMenu>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinMenu"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinMenu(By searchConfiguration = null)
            : this(new CUITControls.WinMenu(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinMenu"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinMenu(CUITControls.WinMenu sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
        
        /// <summary>
        /// Gets the collection of all items in this menu.
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