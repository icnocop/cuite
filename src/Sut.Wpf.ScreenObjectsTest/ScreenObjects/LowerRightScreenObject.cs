using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class LowerRightScreenObject : ScreenObject
    {
        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("oEOhLBF5ske3yGfbHhThuA")).Exists; }
        }
    }
}