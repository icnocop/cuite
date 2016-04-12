using System.ComponentModel;
#if NETFX_45
using System.Runtime.CompilerServices;
#endif

namespace Sut.WinForms.Controls.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private bool isCustomer;
        private Gender gender;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (name == value)
                    return;

                name = value;
                OnPropertyChanged();
            }
        }

        public bool IsCustomer
        {
            get { return isCustomer; }
            set
            {
                if (isCustomer == value)
                    return;

                isCustomer = value;
                OnPropertyChanged();
            }
        }

        public Gender Gender
        {
            get { return gender; }
            set
            {
                if (gender == value)
                    return;

                gender = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged(
#if NETFX_45
            [CallerMemberName]
#endif
            string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}