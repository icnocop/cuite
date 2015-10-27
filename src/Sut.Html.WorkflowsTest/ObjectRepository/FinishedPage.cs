using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Html.WorkflowsTest.ObjectRepository
{
    public class FinishedPage : Page
    {
        public bool CongratulationsExists
        {
            get { return Find<HtmlParagraph>(By.Id("congratulations")).Exists; }
        }
    }
}