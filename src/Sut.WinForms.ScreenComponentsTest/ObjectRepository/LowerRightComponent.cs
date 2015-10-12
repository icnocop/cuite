using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
{
    public class LowerRightComponent : ScreenComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.Name("Lower right control")).Exists; }
        }
    }
}