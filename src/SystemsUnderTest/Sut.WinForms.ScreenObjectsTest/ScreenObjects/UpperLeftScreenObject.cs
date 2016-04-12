using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class UpperLeftScreenObject : ScreenObject
    {
        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.ControlName("checkBoxUpperLeft")).Exists; }
        }
    }
}