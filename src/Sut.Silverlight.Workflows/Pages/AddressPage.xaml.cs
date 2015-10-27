namespace Sut.Silverlight.Workflows.Pages
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