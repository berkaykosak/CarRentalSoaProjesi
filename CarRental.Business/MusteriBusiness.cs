using CarRental.DataAccessLayer.Concrete.EntityFramework.Repository;
using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Business
{
    public class MusteriBusiness:IDisposable
    { /*
     Bu katmanda ihtiyaca göre belirlediğimiz iş kurallarını tanımladık.
     kurallar tanımlanırken DAL daki işlevlerden yararlandık.
     */
        public IList<Musteriler> GetAll()
        {
            try
            {
                using (var nesne = new EfMusteriRepository())
                {
                    var tempMusteri = nesne.GetAll();
                    return tempMusteri.ToList();
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return null;
            }
        }
        public Musteriler GetById(int id)
        {
            try
            {
                using (var nesne = new EfMusteriRepository())
                {
                    var musteri = nesne.GetById(id);
                    return musteri;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return null;
            }
        }
        public bool Delete(Musteriler musteri)
        {
            try
            {
                using (var nesne = new EfMusteriRepository())
                {
                    nesne.Delete(musteri);
                    return true;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return false;
            }
        }
        public bool Insert(Musteriler musteri)
        {
            try
            {
                using (var nesne = new EfMusteriRepository())
                {
                    nesne.Insert(musteri);
                    return true;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return false;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}