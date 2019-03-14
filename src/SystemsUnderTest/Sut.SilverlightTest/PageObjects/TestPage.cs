using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.SilverlightTest.PageObjects
{
    /// <summary>
    /// Test Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class TestPage : Page
    {
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <value>
        /// The list.
        /// </value>
        public SilverlightList List
        {
            get { return Find<SilverlightList>(By.AutomationId("listBox1")); }
        }
    }
}