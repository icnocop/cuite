using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class IdenticalButtonContentScreen : Screen
    {
        public void ClickIdenticalButton()
        {
            Find<WinButton>(By.Name("Identical Button Content")).Click();
        }
    }
}