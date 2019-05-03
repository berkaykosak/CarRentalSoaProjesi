using CarRental.DataAccessLayer.Concrete.EntityFramework.Repository;
using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Business
{
    public class KullaniciBusiness : IDisposable
    { /*
     Bu katmanda ihtiyaca göre belirlediğimiz iş kurallarını tanımladık.
     kurallar tanımlanırken DAL daki işlevlerden yararlandık.
     */
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
        public KullaniciBusiness()
        {

        }

        public bool Login(Kullanicilar user)
        {
            try
            {
                using (var kullanici = new EfKullaniciRepository())
                {
                    if (kullanici.GetAll().Where(kn => kn.Adi == user.Adi && kn.Sifre == user.Sifre).Count() == 1)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return false;
            }
        }
        public IList<Kullanicilar> GetAll()
        {
            try
            {
                using (var kullanici = new EfKullaniciRepository())
                {
                    var temp = kullanici.GetAll();
                    return temp.ToList();
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return null;
            }
        }
    }
}