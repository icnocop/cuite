using CUITe.PageObjects;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class MainPage : Page
    {
        public UpperLeftPageObject UpperLeft
        {
            get { return GetPageObject<UpperLeftPageObject>(); }
        }

        public UpperRightPageObject UpperRight
        {
            get { return GetPageObject<UpperRightPageObject>(); }
        }

        public LowerLeftPageObject LowerLeft
        {
            get { return GetPageObject<LowerLeftPageObject>(); }
        }

        public LowerRightPageObject LowerRight
        {
            get { return GetPageObject<LowerRightPageObject>(); }
        }

        public RebasedUpperLeftPageObject RebasedUpperLeft
        {
            get { return GetPageObject<RebasedUpperLeftPageObject>(); }
        }

        public RebasedUpperRightPageObject RebasedUpperRight
        {
            get { return GetPageObject<RebasedUpperRightPageObject>(); }
        }

        public RebasedLowerLeftPageObject RebasedLowerLeft
        {
            get { return GetPageObject<RebasedLowerLeftPageObject>(); }
        }

        public RebasedLowerRightPageObject RebasedLowerRight
        {
            get { return GetPageObject<RebasedLowerRightPageObject>(); }
        }

        public MiddlePageObject MiddlePageObject
        {
            get { return GetPageObject<MiddlePageObject>(); }
        }
    }
}