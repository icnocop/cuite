using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class IdenticalButtonContentScreen : Screen
    {
        public void ClickIdenticalButton()
        {
            Find<WpfButton>(By.Name("Identical Button Content")).Click();
        }
    }
}