using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.ObjectRepository
{
    public class LowerRightComponent : PageComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<SilverlightRadioButton>(By.AutomationId("0IZpFrh750Kps3zMlrFFcA")).Exists; }
        }
    }
}