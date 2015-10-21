using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
{
    public class LowerLeftComponent : ScreenComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.Name("Lower left control")).Exists; }
        }
    }
}