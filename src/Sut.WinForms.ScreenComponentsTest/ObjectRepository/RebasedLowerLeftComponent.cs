using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
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