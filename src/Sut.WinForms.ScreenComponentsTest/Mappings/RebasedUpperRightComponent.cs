using CUITe.Controls.WinControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.Mappings
{
    public class RebasedUpperRightComponent : ScreenComponent<WinGroup>
    {
        public RebasedUpperRightComponent()
            : base(By.Name("Upper Right Group"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.Name("Upper right control")).Exists; }
        }
    }
}