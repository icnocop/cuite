using CUITe.ScreenObjects;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Main Screen
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class MainScreen : Screen
    {
        /// <summary>
        /// Gets the upper left.
        /// </summary>
        /// <value>
        /// The upper left.
        /// </value>
        public UpperLeftScreenObject UpperLeft
        {
            get { return GetScreenObject<UpperLeftScreenObject>(); }
        }

        /// <summary>
        /// Gets the upper right.
        /// </summary>
        /// <value>
        /// The upper right.
        /// </value>
        public UpperRightScreenObject UpperRight
        {
            get { return GetScreenObject<UpperRightScreenObject>(); }
        }

        /// <summary>
        /// Gets the lower left.
        /// </summary>
        /// <value>
        /// The lower left.
        /// </value>
        public LowerLeftScreenObject LowerLeft
        {
            get { return GetScreenObject<LowerLeftScreenObject>(); }
        }

        /// <summary>
        /// Gets the lower right.
        /// </summary>
        /// <value>
        /// The lower right.
        /// </value>
        public LowerRightScreenObject LowerRight
        {
            get { return GetScreenObject<LowerRightScreenObject>(); }
        }

        /// <summary>
        /// Gets the rebased upper left.
        /// </summary>
        /// <value>
        /// The rebased upper left.
        /// </value>
        public RebasedUpperLeftScreenObject RebasedUpperLeft
        {
            get { return GetScreenObject<RebasedUpperLeftScreenObject>(); }
        }

        /// <summary>
        /// Gets the rebased upper right.
        /// </summary>
        /// <value>
        /// The rebased upper right.
        /// </value>
        public RebasedUpperRightScreenObject RebasedUpperRight
        {
            get { return GetScreenObject<RebasedUpperRightScreenObject>(); }
        }

        /// <summary>
        /// Gets the rebased lower left.
        /// </summary>
        /// <value>
        /// The rebased lower left.
        /// </value>
        public RebasedLowerLeftScreenObject RebasedLowerLeft
        {
            get { return GetScreenObject<RebasedLowerLeftScreenObject>(); }
        }

        /// <summary>
        /// Gets the rebased lower right.
        /// </summary>
        /// <value>
        /// The rebased lower right.
        /// </value>
        public RebasedLowerRightScreenObject RebasedLowerRight
        {
            get { return GetScreenObject<RebasedLowerRightScreenObject>(); }
        }

        /// <summary>
        /// Gets the middle screen object.
        /// </summary>
        /// <value>
        /// The middle screen object.
        /// </value>
        public MiddleScreenObject MiddleScreenObject
        {
            get { return GetScreenObject<MiddleScreenObject>(); }
        }
    }
}