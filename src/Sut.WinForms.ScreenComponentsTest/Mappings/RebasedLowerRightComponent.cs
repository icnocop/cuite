using CUITe.Controls.WinControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.Mappings
{
    public class RebasedLowerRightComponent : ScreenComponent<WinGroup>
    {
        public RebasedLowerRightComponent()
            : base(By.Name("Lower Right Group"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.Name("Lower right control")).Exists; }
        }
    }
}