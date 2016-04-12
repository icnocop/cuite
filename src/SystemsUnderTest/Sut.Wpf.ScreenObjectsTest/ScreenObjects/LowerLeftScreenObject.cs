using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class LowerLeftScreenObject : ScreenObject
    {
        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("U-nw96CGFUuMrbKg3h0tCQ")).Exists; }
        }
    }
}