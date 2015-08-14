using System.Windows;
using System.Windows.Controls;

namespace ControlTemplateExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 50; i++)
            {
                MenuItem newMI = new MenuItem();
                newMI.Header = "Item " + i;
                topFour.Items.Add(newMI);
            }
        }

        void OpenWindow(object sender, RoutedEventArgs args)
        {
            new TestWindow().Visibility = Visibility.Visible;
        }

        void OpenNavWindow(object sender, RoutedEventArgs args)
        {
            new TestNavigationWindow().Visibility = Visibility.Visible;
        }

        private void dg1_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Tag = (e.Row.GetIndex()).ToString();
        }

    }
}
