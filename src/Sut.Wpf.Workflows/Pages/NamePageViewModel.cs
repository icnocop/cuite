using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sut.Wpf.Workflows.Pages
{
    public class NamePageViewModel : INotifyPropertyChanged
    {
        private string firstName;
        private string surname;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName == value)
                    return;

                firstName = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname == value)
                    return;

                surname = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}