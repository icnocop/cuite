using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CUITe.ApplicationUnderTest.Wpf.Controls
{
    public partial class DataGridControl
    {
        public DataGridControl()
        {
            InitializeComponent();

            personDataGrid.ItemsSource = new[]
            {
                new Person { Name = "John Doe", IsProspect = false, Gender = Gender.Male },
                new Person { Name = "Jane Doe", IsProspect = true, Gender = Gender.Female }
            };
        }
    }

    public class Person : INotifyPropertyChanged
    {
        private string name;
        private bool isProspect;
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

        public bool IsProspect
        {
            get { return isProspect; }
            set
            {
                if (isProspect == value)
                    return;

                isProspect = value;
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

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}