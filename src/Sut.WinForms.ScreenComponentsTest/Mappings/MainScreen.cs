using CUITe.Mappings;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Sut.WinForms.ScreenComponentsTest.Mappings
{
    public class MainScreen : Screen
    {
        public MainScreen(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        public UpperLeftComponent UpperLeft
        {
            get { return GetComponent<UpperLeftComponent>(); }
        }

        public UpperRightComponent UpperRight
        {
            get { return GetComponent<UpperRightComponent>(); }
        }

        public LowerLeftComponent LowerLeft
        {
            get { return GetComponent<LowerLeftComponent>(); }
        }

        public LowerRightComponent LowerRight
        {
            get { return GetComponent<LowerRightComponent>(); }
        }
    }
}