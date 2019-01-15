using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class UpperRightScreenObject : ScreenObject
    {
        public bool CheckBoxExists
        {
            get { return this.Window.Find<WinCheckBox>().Exists; }
        }

        private WinWindow Window
        {
            get
            {
                return this.Find<WinWindow>(By.ControlName("checkBoxUpperRight"));
            }
        }
    }
}