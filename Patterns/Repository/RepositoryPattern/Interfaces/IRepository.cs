using System;
using System.Collections.Generic;

namespace RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Add(T entity);

        void Change(T entity);
    }
}