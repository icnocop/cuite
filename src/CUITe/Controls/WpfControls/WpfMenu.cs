using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a Windows Presentation Foundation (WPF) menu object in the user interface (UI)
    /// testing framework.
    /// </summary>
    public class WpfMenu : WpfControl<CUITControls.WpfMenu>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfMenu"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfMenu(By searchConfiguration = null)
            : this(new CUITControls.WpfMenu(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfMenu"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfMenu(CUITControls.WpfMenu sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a collection of items in this menu.
        /// </summary>
        public IEnumerable<WpfMenuItem> Items
        {
            get
            {
                return SourceControl.Items
                    .Cast<CUITControls.WpfMenuItem>()
                    .Select(item => new WpfMenuItem(item))
                    .ToArray();
            }
        }
    }
}