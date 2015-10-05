using CUITe.Controls.WinControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.Mappings
{
    public class RebasedLowerLeftComponent : ScreenComponent<WinGroup>
    {
        public RebasedLowerLeftComponent()
            : base(By.Name("Lower Left Group"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.Name("Lower left control")).Exists; }
        }
    }
}