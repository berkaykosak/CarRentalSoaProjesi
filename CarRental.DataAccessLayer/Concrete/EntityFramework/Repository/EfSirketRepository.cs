using CarRental.Entities;
using CarRentalSoa.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class EfSirketRepository:ISirketRepository,IDisposable
    {
        private readonly CarRentalContex contextNesnesi = new CarRentalContex();
        public EfSirketRepository()
        {
           
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);

        }

        public IEnumerable<Sirket> GetAll()
        {
            return contextNesnesi.Sirket.ToList();
        }

        public Sirket GetById(int id)
        {
            return contextNesnesi.Sirket.Where(s => s.SirketID == id).FirstOrDefault();
        }

        public void Insert(Sirket obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            contextNesnesi.SaveChanges();
        }

        public void Update(Sirket obj)
        {
            throw new NotImplementedException();
        }
    }
}
