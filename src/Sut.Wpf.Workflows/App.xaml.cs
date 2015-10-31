using System.Windows;

namespace Sut.Wpf.Workflows
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var view = new MainWindow
            {
                DataContext = new MainWindowViewModel()
            };

            view.Show();
        }
    }
}