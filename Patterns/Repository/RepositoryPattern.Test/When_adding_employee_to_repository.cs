using System;
using NUnit.Framework;
using RepositoryPattern.Interfaces;

namespace RepositoryPattern.Test
{
    [TestFixture]
    public class When_adding_employee_to_repository
    {
        [SetUp]
        public void SetUp()
        {
            _employeeRepository = new MockEmployeeRepository();
        }

        private IEmployeeRepository _employeeRepository;

        [Test]
        public void It_should_add_employee_to_repository()
        {
            var id = Guid.NewGuid();
            var firstName = "FirstName1";
            var surname = "Surname1";
            var birthDate = new DateTime(2001, 1, 1);
            _employeeRepository.Add(new Employee
            {
                Id = id,
                FirstName = firstName,
                Surname = surname,
                BirthDate = birthDate
            });

            var result = _employeeRepository.GetById(id);

            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.AreEqual(id, result.Id);
                Assert.AreEqual(firstName, result.FirstName);
                Assert.AreEqual(surname, result.Surname);
                Assert.AreEqual(birthDate, result.BirthDate);
            });
        }
    }
}