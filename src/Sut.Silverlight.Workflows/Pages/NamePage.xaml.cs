namespace Sut.Silverlight.Workflows.Pages
{
    public partial class NamePage
    {
        public NamePage()
        {
            InitializeComponent();

            Loaded += (sender, args) => firstNameTextBox.Focus();
        }
    }
}