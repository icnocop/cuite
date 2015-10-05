using CUITe.Controls.WinControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.Mappings
{
    public class RebasedUpperLeftComponent : ScreenComponent<WinGroup>
    {
        public RebasedUpperLeftComponent()
            : base(By.Name("Upper Left Group"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.Name("Upper left control")).Exists; }
        }
    }
}