using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenP2.Core.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);

        void Update(T entity);
    }
}
