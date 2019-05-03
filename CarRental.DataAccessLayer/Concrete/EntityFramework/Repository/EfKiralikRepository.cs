using CarRental.Entities;
using CarRentalSoa.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.DataAccessLayer.Concrete.EntityFramework.Repository
{ 
    public class EfKiralikRepository:IKiralikRepository,IDisposable
    {

        private readonly CarRentalContex contextNesnesi;

        public EfKiralikRepository()
        {
            contextNesnesi = new CarRentalContex();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<KiralikBilgi> GetAll()
        {
            return contextNesnesi.Kiralik.Where(obj => obj.Durum == true).ToList();

        }

        public KiralikBilgi GetById(int id)
        {
            return contextNesnesi.Kiralik.Where(obj => obj.KiralikID == id).FirstOrDefault();
        }

        public void Insert(KiralikBilgi obj)
        {
            contextNesnesi.Kiralik.Add(obj);
        }

        public void Save()
        {
            contextNesnesi.SaveChanges();
        }

        public void Update(KiralikBilgi obj)
        {
            if (obj!=null)
                contextNesnesi.Entry(obj).State=EntityState.Modified;
        }
    }
}
