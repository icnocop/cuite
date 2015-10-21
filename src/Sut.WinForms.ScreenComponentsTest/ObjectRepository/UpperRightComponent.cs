using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
{
    public class UpperRightComponent : ScreenComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.Name("Upper right control")).Exists; }
        }
    }
}