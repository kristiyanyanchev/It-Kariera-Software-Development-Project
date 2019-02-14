using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> List();
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
