using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.WorkflowsTest.PageObjects
{
    public class FinishedPage : Page
    {
        public bool CongratulationsExists
        {
            get { return Find<HtmlParagraph>(By.Id("congratulations")).Exists; }
        }
    }
}