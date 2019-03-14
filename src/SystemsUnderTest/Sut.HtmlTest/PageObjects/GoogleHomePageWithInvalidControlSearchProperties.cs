using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    /// <summary>
    /// Google Home Page With Invalid Control Search Properties
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class GoogleHomePageWithInvalidControlSearchProperties : Page
    {
        /// <summary>
        /// Gets the control with invalid search properties.
        /// </summary>
        /// <value>
        /// The control with invalid search properties.
        /// </value>
        public HtmlDiv ControlWithInvalidSearchProperties
        {
            get { return Find<HtmlDiv>(By.SearchProperties("blanblah=res")); }
        }
    }
}