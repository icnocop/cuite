using CUITe.Controls.SilverlightControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.Mappings
{
    public class RebasedLowerRightComponent : PageComponent<SilverlightTabItem>
    {
        public RebasedLowerRightComponent()
            : base(By.AutomationId("vzoWE0pag0S7yk0Wmb9iug"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<SilverlightRadioButton>(By.AutomationId("0IZpFrh750Kps3zMlrFFcA")).Exists; }
        }
    }
}