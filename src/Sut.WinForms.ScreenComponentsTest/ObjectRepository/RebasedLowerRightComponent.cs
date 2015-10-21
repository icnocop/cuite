using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
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