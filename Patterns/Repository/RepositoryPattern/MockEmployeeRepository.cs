using System;
using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.Exceptions;
using RepositoryPattern.Interfaces;

namespace RepositoryPattern
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly ICollection<Employee> _employees;

        public MockEmployeeRepository()
        {
            _employees = new HashSet<Employee>();
        }

        public Employee GetById(Guid id)
        {
            var result = _employees.SingleOrDefault(e => e.Id == id);

            if (result == null)
            {
                throw new EmployeeNotFoundException(id);
            }

            return new Employee(result);
        }

        public IEnumerable<Employee> GetAll()
        {
            var result = _employees.Select(e => new Employee(e)).ToList();
            return result;
        }

        public void Add(Employee entity)
        {
            if (entity != null)
            {
                _employees.Add(entity);
            }
        }

        public void Change(Employee entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var entityToChange = _employees.SingleOrDefault(e => e.Id == entity.Id);

            if (entityToChange == null)
            {
                throw new EmployeeNotFoundException(entity.Id);
            }

            UpdateEntity(entity, entityToChange);
        }

        private static void UpdateEntity(Employee entity, Employee entityToChange)
        {
            entityToChange.FirstName = entity.FirstName;
            entityToChange.Surname = entity.Surname;
            entityToChange.BirthDate = entity.BirthDate;
        }
    }
}