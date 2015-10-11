using CUITe.Controls.SilverlightControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.Mappings
{
    public class LowerLeftComponent : PageComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<SilverlightRadioButton>(By.AutomationId("R96eNzWZrUeCOUOiCb5qEQ")).Exists; }
        }
    }
}