using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Sut.Silverlight.Workflows.Pages;

namespace Sut.Silverlight.Workflows
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly INotifyPropertyChanged[] pages;

        private INotifyPropertyChanged currentPage;

        public MainWindowViewModel()
        {
            PreviousCommand = new RelayCommand(Previous, CanPrevious);
            NextCommand = new RelayCommand(Next, CanNext);

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
                OnPropertyChanged("CurrentPage");
                OnPropertyChanged("ButtonsVisibility");
            }
        }

        public ICommand PreviousCommand { get; }

        public ICommand NextCommand { get; }

        public Visibility ButtonsVisibility
        {
            get
            {
                return CurrentPage != pages.Last() ?
                    Visibility.Visible :
                    Visibility.Collapsed;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
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