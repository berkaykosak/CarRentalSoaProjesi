using CarRental.Business;
using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CarRental.Servis
{
    /// <summary>
    /// AracServisi için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class AracServisi : System.Web.Services.WebService
    {

        [WebMethod]
        public Arac[] GetAll()
        {
            try
            {
                using (var nesne = new AracBusiness())
                {
                    return nesne.GetAll().ToArray();
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
                return null;
            }
        }
        [WebMethod]
        public bool Update(Arac aracBilgi)
        {
            try
            {
                using (var nesne = new AracBusiness())
                {
                    return nesne.Update(aracBilgi);
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