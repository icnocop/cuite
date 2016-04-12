using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class RebasedLowerRightScreenObject : ScreenObject<WpfGroup>
    {
        public RebasedLowerRightScreenObject()
            : base(By.AutomationId("4zQL8W23A0ODIzgYYhP4tA"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("oEOhLBF5ske3yGfbHhThuA")).Exists; }
        }
    }
}