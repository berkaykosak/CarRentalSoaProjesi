using CarRental.DataAccessLayer.Concrete.EntityFramework.Repository;
using CarRental.Entities;
using CarRentalSoa.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class EfAracRepository:IAracRepository,IDisposable
    {
        private readonly CarRentalContex contextNesnesi = new CarRentalContex();
        public EfAracRepository()
        {
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<Arac> GetAll()
        {
            return contextNesnesi.Arac.ToList();
        }

        public Arac GetById(int id)
        {
            return contextNesnesi.Arac.Where(s => s.AracID == id).FirstOrDefault();
        }

        public void Insert(Arac obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            contextNesnesi.SaveChanges();
        }

        public void Update(Arac obj)
        {
            if (obj != null)
                contextNesnesi.Entry(obj).State = EntityState.Modified;
        }
    }
}


