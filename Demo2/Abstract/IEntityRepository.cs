using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2.Abstract
{
    public interface IEntityRepository<T> where T: class , IEntity , new()
    {
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

    }
}
