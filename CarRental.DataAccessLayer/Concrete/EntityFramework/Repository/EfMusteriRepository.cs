using CarRental.Entities;
using CarRentalSoa.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class EfMusteriRepository :IMusteriRepository,IDisposable
    {

        private readonly CarRentalContex contextNesnesi = new CarRentalContex();
        public EfMusteriRepository()
        {
           
        }

        public void Delete(Musteriler obj)
        {
            if (obj != null)
                contextNesnesi.Entry(obj).State = EntityState.Deleted;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);

        }

        public IEnumerable<Musteriler> GetAll()
        {
            return contextNesnesi.Musteri.ToList();
        }

        public Musteriler GetById(int id)
        {
            return contextNesnesi.Musteri.Where(nesne => nesne.MusteriID == id).FirstOrDefault();
        }

        public void Insert(Musteriler obj)
        {
            contextNesnesi.Musteri.Add(obj);
        }

        public void Save()
        {
            contextNesnesi.SaveChanges();
        }

        public void Update(Musteriler obj)
        {
            if (obj != null)
                contextNesnesi.Entry(obj).State = EntityState.Modified;
        }
    }
}
