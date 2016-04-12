using CUITe.ScreenObjects;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class MainScreen : Screen
    {
        public UpperLeftScreenObject UpperLeft
        {
            get { return GetScreenObject<UpperLeftScreenObject>(); }
        }

        public UpperRightScreenObject UpperRight
        {
            get { return GetScreenObject<UpperRightScreenObject>(); }
        }

        public LowerLeftScreenObject LowerLeft
        {
            get { return GetScreenObject<LowerLeftScreenObject>(); }
        }

        public LowerRightScreenObject LowerRight
        {
            get { return GetScreenObject<LowerRightScreenObject>(); }
        }

        public RebasedUpperLeftScreenObject RebasedUpperLeft
        {
            get { return GetScreenObject<RebasedUpperLeftScreenObject>(); }
        }

        public RebasedUpperRightScreenObject RebasedUpperRight
        {
            get { return GetScreenObject<RebasedUpperRightScreenObject>(); }
        }

        public RebasedLowerLeftScreenObject RebasedLowerLeft
        {
            get { return GetScreenObject<RebasedLowerLeftScreenObject>(); }
        }

        public RebasedLowerRightScreenObject RebasedLowerRight
        {
            get { return GetScreenObject<RebasedLowerRightScreenObject>(); }
        }

        public MiddleScreenObject MiddleScreenObject
        {
            get { return GetScreenObject<MiddleScreenObject>(); }
        }
    }
}