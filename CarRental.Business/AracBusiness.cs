using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Entities;
using CarRental.DataAccessLayer.Concrete.EntityFramework.Repository;
using System.Linq;

namespace CarRental.Business

    /*
     Bu katmanda ihtiyaca göre belirlediğimiz iş kurallarını tanımladık.
     kurallar tanımlanırken DAL daki işlevlerden yararlandık.
     */
{
    public class AracBusiness : IDisposable
    {
        public AracBusiness()
        {

        }
        public IList<Arac> GetAll()
        {
            try
            {
                using (var nesne = new EfAracRepository())
                {
                    var randomList = nesne.GetAll();
                    return randomList.ToList();
                }
            }


            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return null;
            }
        }
        public bool Update(Arac AracNesnesi)
        {
            try
            {
                using (var nesne = new EfAracRepository())
                {
                    nesne.Update(AracNesnesi);
                    return true;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return false;
            }
        }
        public Arac GetById(int id)
        {
            try
            {
                using (var nesne = new EfAracRepository())
                {
                    var aracNesne = nesne.GetById(id);
                    return (Arac)aracNesne;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return null;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}

