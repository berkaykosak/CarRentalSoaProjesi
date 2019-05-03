using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataTransferObject


    /*
     
 Herhangi bir sınıfta oluşturulan nesneyi ve özelliğini başka bir sınıfta kullanmak için kullandık.
 iki farklı modelden gelen proporty'yi harmanlayarak bir model oluşturmak için DTO modelini kullandık.
 
 
 
 
 */
{
    public class AracTransferObject
    {
        [Key]
        public int AracID { get; set; }

        public string AracMarka { get; set; }

        public string Model { get; set; }

        public int? EhliyetYasi { get; set; }

        public int? MinYasSiniri { get; set; }

        public int? GunlukSinirKM { get; set; }

        public long? KendiAnlikKM { get; set; }

        public bool? AirBag { get; set; }

        public int? BagajHacmi { get; set; }

        public int? KoltukSayisi { get; set; }

        public decimal? GunlukKiralikFiyat { get; set; }

        public int? SirketID { get; set; }

        public bool? Rezerve { get; set; }





    }
}
