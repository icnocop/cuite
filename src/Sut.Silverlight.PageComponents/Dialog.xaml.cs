using System.Windows;

namespace Sut.Silverlight.PageComponents
{
    public partial class Dialog
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}