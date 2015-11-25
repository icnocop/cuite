using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
{
    public class RebasedUpperRightComponent : ScreenComponent<WinGroup>
    {
        public RebasedUpperRightComponent()
            : base(By.ControlName("groupBoxUpperRight"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.ControlName("checkBoxUpperRight")).Exists; }
        }
    }
}