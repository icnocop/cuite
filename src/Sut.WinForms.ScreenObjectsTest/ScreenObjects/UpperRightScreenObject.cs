using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class UpperRightScreenObject : ScreenObject
    {
        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.ControlName("checkBoxUpperRight")).Exists; }
        }
    }
}