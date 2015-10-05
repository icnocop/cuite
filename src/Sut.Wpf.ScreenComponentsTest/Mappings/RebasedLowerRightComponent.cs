﻿using CUITe.Controls.WpfControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.Mappings
{
    public class RebasedLowerRightComponent : ScreenComponent<WpfGroup>
    {
        public RebasedLowerRightComponent()
            : base(By.AutomationId("4zQL8W23A0ODIzgYYhP4tA"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("oEOhLBF5ske3yGfbHhThuA")).Exists; }
        }
    }
}