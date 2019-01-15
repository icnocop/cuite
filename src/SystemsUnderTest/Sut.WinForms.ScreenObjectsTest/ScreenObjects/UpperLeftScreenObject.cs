using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class UpperLeftScreenObject : ScreenObject
    {
        public bool CheckBoxExists
        {
            get { return this.Window.Find<WinCheckBox>().Exists; }
        }

        private WinWindow Window
        {
            get
            {
                return this.Find<WinWindow>(By.ControlName("checkBoxUpperLeft"));
            }
        }
    }
}