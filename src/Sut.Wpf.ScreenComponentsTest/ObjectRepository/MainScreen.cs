using CUITe.ObjectRepository;

namespace Sut.Wpf.ScreenComponentsTest.ObjectRepository
{
    public class MainScreen : Screen
    {
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

        public RebasedUpperLeftComponent RebasedUpperLeft
        {
            get { return GetComponent<RebasedUpperLeftComponent>(); }
        }

        public RebasedUpperRightComponent RebasedUpperRight
        {
            get { return GetComponent<RebasedUpperRightComponent>(); }
        }

        public RebasedLowerLeftComponent RebasedLowerLeft
        {
            get { return GetComponent<RebasedLowerLeftComponent>(); }
        }

        public RebasedLowerRightComponent RebasedLowerRight
        {
            get { return GetComponent<RebasedLowerRightComponent>(); }
        }

        public MiddleComponent MiddleComponent
        {
            get { return GetComponent<MiddleComponent>(); }
        }
    }
}