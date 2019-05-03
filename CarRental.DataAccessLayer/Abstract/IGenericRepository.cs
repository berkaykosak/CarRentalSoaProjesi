using System;
using System.Collections.Generic;

namespace CarRentalSoa.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T>:IDisposable where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Update(T obj);
        void Save();
    }
}
