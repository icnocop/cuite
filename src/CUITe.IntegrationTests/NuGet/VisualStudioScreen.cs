using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace CUITe.IntegrationTests.NuGet
{
    /// <summary>
    /// Visual Studio Screen
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class VisualStudioScreen : Screen
    {
        /// <summary>
        /// Gets the menu bar.
        /// </summary>
        /// <value>
        /// The menu bar.
        /// </value>
        public WpfControl MenuBar
        {
            get
            {
                return this.Find<WpfControl>(By.AutomationId("MenuBar").AndControlType("MenuBar"));
            }
        }

        /// <summary>
        /// Gets the test menu item.
        /// </summary>
        /// <value>
        /// The test menu item.
        /// </value>
        public WpfMenuItem TestMenuItem
        {
            get { return this.MenuBar.Find<WpfMenuItem>(By.Name("Test")); }
        }

        /// <summary>
        /// Gets the test settings menu item.
        /// </summary>
        /// <value>
        /// The test settings menu item.
        /// </value>
        public WpfMenuItem TestSettingsMenuItem
        {
            get { return this.TestMenuItem.Find<WpfMenuItem>(By.Name("Test Settings")); }
        }

        /// <summary>
        /// Gets the select test settings file menu item.
        /// </summary>
        /// <value>
        /// The select test settings file menu item.
        /// </value>
        public WpfMenuItem SelectTestSettingsFileMenuItem
        {
            get { return this.TestSettingsMenuItem.Find<WpfMenuItem>(By.Name("Select Test Settings File")); }
        }
    }
}
