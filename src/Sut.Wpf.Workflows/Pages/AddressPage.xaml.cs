namespace Sut.Wpf.Workflows.Pages
{
    public partial class AddressPage
    {
        public AddressPage()
        {
            InitializeComponent();

            Loaded += (sender, args) => addressTextBox.Focus();
        }
    }
}