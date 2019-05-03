using CarRental.DataAccessLayer.Concrete.EntityFramework.Repository;
using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Business
{
    public class KiralikBusiness : IDisposable
    { /*
     Bu katmanda ihtiyaca göre belirlediğimiz iş kurallarını tanımladık.
     kurallar tanımlanırken DAL daki işlevlerden yararlandık.
     */


        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
        public IList<KiralikBilgi> GetAll()
        {
            try
            {
                using (var nesne= new EfKiralikRepository())
                {
                    var temp = nesne.GetAll();
                    return temp.ToList();
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return null;
            }
        }
        public KiralikBilgi GetById(int id)
        {
            try
            {
                using (var nesne = new EfKiralikRepository())
                {
                    var aracNesnesi = nesne.GetById(id);
                    return aracNesnesi;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return null;
            }
        }
        public bool Update(KiralikBilgi rentedCar)
        {
            try
            {
                using (var nesne = new EfKiralikRepository())
                {
                    nesne.Update(rentedCar);
                    return true;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return false;
            }
        }
        public bool Insert(KiralikBilgi kiralikArac)
        {
            try
            {
                using (var nesne = new EfKiralikRepository())
                {
                    nesne.Insert(kiralikArac);
                    return true;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return false;
            }
        }
    }
}