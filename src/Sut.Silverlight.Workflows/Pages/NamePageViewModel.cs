using System.ComponentModel;

namespace Sut.Silverlight.Workflows.Pages
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
                OnPropertyChanged("FirstName");
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
                OnPropertyChanged("Surname");
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
    }
}