using CUITe.Controls.WinControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.Mappings
{
    public class UpperRightComponent : ScreenComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.Name("Upper right")).Exists; }
        }
    }
}