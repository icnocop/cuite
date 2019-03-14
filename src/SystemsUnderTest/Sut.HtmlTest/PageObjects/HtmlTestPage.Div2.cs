using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    /// <summary>
    /// Div 2
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{HtmlDiv}" />
    public class Div2 : PageObject<HtmlDiv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Div2"/> class.
        /// </summary>
        public Div2()
            : base(By.Id("div2"))
        {
        }

        /// <summary>
        /// Gets the edit box.
        /// </summary>
        /// <value>
        /// The edit box.
        /// </value>
        public HtmlEdit Edit
        {
            get { return Find<HtmlEdit>(By.Id("edit")); }
        }
    }
}