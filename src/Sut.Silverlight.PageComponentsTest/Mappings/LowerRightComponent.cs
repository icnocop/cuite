using CUITe.Controls.SilverlightControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.Mappings
{
    public class LowerRightComponent : PageComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<SilverlightRadioButton>(By.AutomationId("0IZpFrh750Kps3zMlrFFcA")).Exists; }
        }
    }
}