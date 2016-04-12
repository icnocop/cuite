using System.Windows;

namespace Sut.Silverlight.PageObjects
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOpenDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Dialog();
            dialog.Show();
        }
    }
}