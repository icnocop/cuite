using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    /// <summary>
    /// Div 1
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject{HtmlDiv}" />
    public class Div1 : PageObject<HtmlDiv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Div1"/> class.
        /// </summary>
        public Div1()
            : base(By.Id("div1"))
        {
        }

        /// <summary>
        /// Gets the div2.
        /// </summary>
        /// <value>
        /// The div2.
        /// </value>
        public Div2 Div2
        {
            get { return GetPageObject<Div2>(); }
        }
    }
}