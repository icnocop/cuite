using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.ObjectRepository
{
    public class RebasedUpperRightComponent : PageComponent<SilverlightTabItem>
    {
        public RebasedUpperRightComponent()
            : base(By.AutomationId("sk0ELlIxRkSChVuWnKrEMw"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<SilverlightCheckBox>(By.AutomationId("pxr987yTh0u0k72WGfOimw")).Exists; }
        }
    }
}