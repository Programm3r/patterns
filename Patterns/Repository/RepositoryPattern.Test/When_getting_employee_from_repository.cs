using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RepositoryPattern.Exceptions;
using RepositoryPattern.Interfaces;

namespace RepositoryPattern.Test
{
    [TestFixture]
    public class When_getting_employee_from_repository
    {
        [SetUp]
        public void SetUp()
        {
            _employeeRepository = new MockEmployeeRepository();
            _employeeRepository
                .Add(new Employee
                {
                    Id = _id1,
                    BirthDate = _birthDate1,
                    Surname = _surname1,
                    FirstName = _firstName1
                });
            _employeeRepository
                .Add(new Employee
                {
                    Id = _id2,
                    BirthDate = _birthDate2,
                    Surname = _surname2,
                    FirstName = _firstName2
                });
            _employeeRepository
                .Add(new Employee
                {
                    Id = _id3,
                    BirthDate = _birthDate3,
                    Surname = _surname3,
                    FirstName = _firstName3
                });
            _employeeRepository
                .Add(new Employee
                {
                    Id = _id4,
                    BirthDate = _birthDate4,
                    Surname = _surname4,
                    FirstName = _firstName4
                });
        }

        private IEmployeeRepository _employeeRepository;
        private readonly Guid _id1 = Guid.NewGuid();
        private readonly Guid _id2 = Guid.NewGuid();
        private readonly Guid _id3 = Guid.NewGuid();
        private readonly Guid _id4 = Guid.NewGuid();
        private readonly string _firstName1 = "FirstName1";
        private readonly string _firstName2 = "FirstName2";
        private readonly string _firstName3 = "FirstName3";
        private readonly string _firstName4 = "FirstName4";
        private readonly string _surname1 = "Surname1";
        private readonly string _surname2 = "Surname2";
        private readonly string _surname3 = "Surname3";
        private readonly string _surname4 = "Surname4";
        private readonly DateTime _birthDate1 = new DateTime(2001, 1, 1);
        private readonly DateTime _birthDate2 = new DateTime(2002, 2, 2);
        private readonly DateTime _birthDate3 = new DateTime(2003, 3, 3);
        private readonly DateTime _birthDate4 = new DateTime(2004, 4, 4);

        [Test]
        public void It_should_return_all_employees()
        {
            IEnumerable<Employee> result = _employeeRepository.GetAll();
            Assert.AreEqual(4, result.Count());
        }

        [Test]
        public void It_should_return_correct_employee()
        {
            Employee result = _employeeRepository.GetById(_id3);

            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.AreEqual(_id3, result.Id);
                Assert.AreEqual(_firstName3, result.FirstName);
                Assert.AreEqual(_surname3, result.Surname);
                Assert.AreEqual(_birthDate3, result.BirthDate);
            });
        }

        [Test]
        public void It_should_throw_exception()
        {
            Assert.Catch<EmployeeNotFoundException>(() => { _employeeRepository.GetById(Guid.NewGuid()); });
        }
    }
}