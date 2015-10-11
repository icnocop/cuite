using CUITe.Controls.SilverlightControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.Mappings
{
    public class UpperRightComponent : PageComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<SilverlightCheckBox>(By.AutomationId("pxr987yTh0u0k72WGfOimw")).Exists; }
        }
    }
}