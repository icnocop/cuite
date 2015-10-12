using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.ObjectRepository
{
    public class RebasedLowerLeftComponent : PageComponent<SilverlightTabItem>
    {
        public RebasedLowerLeftComponent()
            : base(By.AutomationId("6B4YMUMZz0CAxPbskr1MgQ"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<SilverlightRadioButton>(By.AutomationId("R96eNzWZrUeCOUOiCb5qEQ")).Exists; }
        }
    }
}