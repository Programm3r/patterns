using System;
using RepositoryPattern.Interfaces;

namespace RepositoryPattern
{
    public class Employee : IEntity
    {
        public Employee()
        {
        }

        public Employee(Employee toCopy)
        {
            Id = toCopy.Id;
            FirstName = toCopy.FirstName;
            Surname = toCopy.Surname;
            BirthDate = toCopy.BirthDate;
        }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public Guid Id { get; set; }
    }
}