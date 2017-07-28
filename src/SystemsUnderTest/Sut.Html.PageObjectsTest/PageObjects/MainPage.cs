using CUITe.PageObjects;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Main Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class MainPage : Page
    {
        /// <summary>
        /// Gets the upper left.
        /// </summary>
        /// <value>
        /// The upper left.
        /// </value>
        public UpperLeftPageObject UpperLeft
        {
            get { return GetPageObject<UpperLeftPageObject>(); }
        }

        /// <summary>
        /// Gets the upper right.
        /// </summary>
        /// <value>
        /// The upper right.
        /// </value>
        public UpperRightPageObject UpperRight
        {
            get { return GetPageObject<UpperRightPageObject>(); }
        }

        /// <summary>
        /// Gets the lower left.
        /// </summary>
        /// <value>
        /// The lower left.
        /// </value>
        public LowerLeftPageObject LowerLeft
        {
            get { return GetPageObject<LowerLeftPageObject>(); }
        }

        /// <summary>
        /// Gets the lower right.
        /// </summary>
        /// <value>
        /// The lower right.
        /// </value>
        public LowerRightPageObject LowerRight
        {
            get { return GetPageObject<LowerRightPageObject>(); }
        }

        /// <summary>
        /// Gets the rebased upper left.
        /// </summary>
        /// <value>
        /// The rebased upper left.
        /// </value>
        public RebasedUpperLeftPageObject RebasedUpperLeft
        {
            get { return GetPageObject<RebasedUpperLeftPageObject>(); }
        }

        /// <summary>
        /// Gets the rebased upper right.
        /// </summary>
        /// <value>
        /// The rebased upper right.
        /// </value>
        public RebasedUpperRightPageObject RebasedUpperRight
        {
            get { return GetPageObject<RebasedUpperRightPageObject>(); }
        }

        /// <summary>
        /// Gets the rebased lower left.
        /// </summary>
        /// <value>
        /// The rebased lower left.
        /// </value>
        public RebasedLowerLeftPageObject RebasedLowerLeft
        {
            get { return GetPageObject<RebasedLowerLeftPageObject>(); }
        }

        /// <summary>
        /// Gets the rebased lower right.
        /// </summary>
        /// <value>
        /// The rebased lower right.
        /// </value>
        public RebasedLowerRightPageObject RebasedLowerRight
        {
            get { return GetPageObject<RebasedLowerRightPageObject>(); }
        }

        /// <summary>
        /// Gets the middle page object.
        /// </summary>
        /// <value>
        /// The middle page object.
        /// </value>
        public MiddlePageObject MiddlePageObject
        {
            get { return GetPageObject<MiddlePageObject>(); }
        }
    }
}