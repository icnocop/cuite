using System.ComponentModel;
#if NETFX_45
using System.Runtime.CompilerServices;
#endif

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
    }
}