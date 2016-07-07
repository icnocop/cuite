using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace CUITe.IntegrationTests.NuGet
{
    public class VisualStudioScreen : Screen
    {
        public WpfControl MenuBar
        {
            get
            {
                return this.Find<WpfControl>(By.AutomationId("MenuBar").AndControlType("MenuBar"));
            }
        }

        public WpfMenuItem TestMenuItem
        {
            get { return this.MenuBar.Find<WpfMenuItem>(By.Name("Test")); }
        }

        public WpfMenuItem TestSettingsMenuItem
        {
            get { return this.TestMenuItem.Find<WpfMenuItem>(By.Name("Test Settings")); }
        }

        public WpfMenuItem SelectTestSettingsFileMenuItem
        {
            get { return this.TestSettingsMenuItem.Find<WpfMenuItem>(By.Name("Select Test Settings File")); }
        }
    }
}
