using System;
using System.ComponentModel;
using System.Linq;
#if NETFX_45
using System.Runtime.CompilerServices;
#endif
using System.Windows;
using System.Windows.Input;
using Sut.Wpf.Workflows.Pages;

namespace Sut.Wpf.Workflows
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ICommand previousCommand;
        private readonly ICommand nextCommand;
        private readonly INotifyPropertyChanged[] pages; 

        private INotifyPropertyChanged currentPage;

        public MainWindowViewModel()
        {
            previousCommand = new RelayCommand(Previous, CanPrevious);
            nextCommand = new RelayCommand(Next, CanNext);

            pages = new INotifyPropertyChanged[]
            {
                new NamePageViewModel(),
                new AddressPageViewModel(),
                new FinishedPageViewModel()
            };

            currentPage = pages.First();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public INotifyPropertyChanged CurrentPage
        {
            get { return currentPage; }
            private set
            {
                if (currentPage == value)
                    return;

                currentPage = value;
                OnPropertyChanged();
// ReSharper disable once ExplicitCallerInfoArgument
                OnPropertyChanged("ButtonsVisibility");
            }
        }

        public ICommand PreviousCommand
        {
            get { return previousCommand; }
        }

        public ICommand NextCommand
        {
            get { return nextCommand; }
        }

        public Visibility ButtonsVisibility
        {
            get
            {
                return CurrentPage != pages.Last() ?
                    Visibility.Visible :
                    Visibility.Collapsed;
            }
        }

        protected virtual void OnPropertyChanged(
#if NETFX_45
            [CallerMemberName]
#endif
            string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool CanPrevious()
        {
            return CurrentPage != pages.First();
        }

        private void Previous()
        {
            CurrentPage = pages[Array.IndexOf(pages, CurrentPage) - 1];
        }

        private bool CanNext()
        {
            return CurrentPage != pages.Last();
        }

        private void Next()
        {
            CurrentPage = pages[Array.IndexOf(pages, CurrentPage) + 1];
        }
    }
}