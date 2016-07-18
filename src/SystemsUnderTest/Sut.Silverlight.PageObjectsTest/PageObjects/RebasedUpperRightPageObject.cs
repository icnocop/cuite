using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    public class RebasedUpperRightPageObject : PageObject<SilverlightTab>
    {
        public RebasedUpperRightPageObject()
            : base(By.AutomationId("sk0ELlIxRkSChVuWnKrEMw"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<SilverlightCheckBox>(By.AutomationId("pxr987yTh0u0k72WGfOimw")).Exists; }
        }
    }
}