using System;
using System.ComponentModel;

namespace Sut.WinForms.Controls.Models
{
    public static class Mocked
    {
        private static readonly Lazy<BindingList<Person>> LazyPersons;

        static Mocked()
        {
            LazyPersons = new Lazy<BindingList<Person>>(
                () => new BindingList<Person>
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

        public static BindingList<Person> Persons
        {
            get { return LazyPersons.Value; }
        }
    }
}