using System;
using System.Collections.ObjectModel;

namespace Sut.Wpf.Controls.Models
{
    public static class Mocked
    {
        private static readonly Lazy<ObservableCollection<Person>> LazyPersons;
        
        static Mocked()
        {
            LazyPersons = new Lazy<ObservableCollection<Person>>(
                () => new ObservableCollection<Person>
                {
                    new Person
                    {
                        Name = "Emma",
                        IsCustomer = true,
                        Gender = Gender.Female
                    },
                    new Person
                    {
                        Name = "Noah",
                        IsCustomer = true,
                        Gender = Gender.Male
                    },
                    new Person
                    {
                        Name = "Olivia",
                        IsCustomer = false,
                        Gender = Gender.Female
                    }
                });
        }

        public static ObservableCollection<Person> Persons
        {
            get { return LazyPersons.Value; }
        }
    }
}