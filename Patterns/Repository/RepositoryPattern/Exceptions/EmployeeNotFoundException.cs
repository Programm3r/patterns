using System;

namespace RepositoryPattern.Exceptions
{
    public class EmployeeNotFoundException : SystemException
    {
        public EmployeeNotFoundException(Guid id)
            : base($"Employee Id: {id} not found.")
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}