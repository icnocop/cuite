using CUITe.ObjectRepository;

namespace Sut.Wpf.WorkflowsTest.ObjectRepository
{
    public class MainScreen : Screen
    {
        public NameScreenComponent NamePage
        {
            get { return GetComponent<NameScreenComponent>(); }
        }
    }
}