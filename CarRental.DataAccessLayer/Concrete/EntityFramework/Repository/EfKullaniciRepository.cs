

using CarRental.Entities;
using CarRentalSoa.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.DataAccessLayer.Concrete.EntityFramework.Repository
{
   public class EfKullaniciRepository:IKullaniciRepository,IDisposable
    {
        private readonly CarRentalContex contextNesnesi = new CarRentalContex();
        public EfKullaniciRepository()
        {
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<Kullanicilar> GetAll()
        {
            return contextNesnesi.Kullanici.ToList();
        }

        public Kullanicilar GetById(int id)
        {
            return contextNesnesi.Kullanici.Where(nesne => nesne.KullaniciID == id).FirstOrDefault();
        }

        public void Insert(Kullanicilar obj)
        {
            contextNesnesi.Kullanici.Add(obj);
        }

        public void Save()
        {
            contextNesnesi.SaveChanges();
        }

        public void Update(Kullanicilar obj)
        {
            if (obj != null)
                contextNesnesi.Entry(obj).State = EntityState.Modified;
        }
    }
}
