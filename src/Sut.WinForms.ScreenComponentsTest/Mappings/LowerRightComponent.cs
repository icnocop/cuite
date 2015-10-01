using CUITe.Controls.WinControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.Mappings
{
    public class LowerRightComponent : ScreenComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.Name("Lower right")).Exists; }
        }
    }
}