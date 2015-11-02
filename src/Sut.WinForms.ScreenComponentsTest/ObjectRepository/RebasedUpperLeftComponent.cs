using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
{
    public class RebasedUpperLeftComponent : ScreenComponent<WinGroup>
    {
        public RebasedUpperLeftComponent()
            : base(By.ControlName("groupBoxUpperLeft"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.ControlName("checkBoxUpperLeft")).Exists; }
        }
    }
}