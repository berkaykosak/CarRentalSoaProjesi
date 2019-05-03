using CarRental.DataAccessLayer.Concrete.EntityFramework.Repository;
using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Business
{
    public class SirketBusiness:IDisposable
    { /*
     Bu katmanda ihtiyaca göre belirlediğimiz iş kurallarını tanımladık.
     kurallar tanımlanırken DAL daki işlevlerden yararlandık.

     */
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IList<Sirket> GetAll()
        {
            try
            {
                using (var sirket = new EfSirketRepository())
                {
                    var sirketList = sirket.GetAll();
                    return sirketList.ToList();
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
