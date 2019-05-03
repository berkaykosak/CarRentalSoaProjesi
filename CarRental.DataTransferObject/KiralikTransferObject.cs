using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataTransferObject
{
    /*

Herhangi bir sınıfta oluşturulan nesneyi ve özelliğini başka bir sınıfta kullanmak için kullandık.
iki farklı modelden gelen proporty'yi harmanlayarak bir model oluşturmak için DTO modelini kullandık.




*/
    public class KiralikTransferObject
    {
        [Key]
        public int KiralikID { get; set; }

        public int? AracID { get; set; }

        public DateTime? KiralamaTarihi { get; set; }

        public DateTime? GeriVermeTarihi { get; set; }

        public long? VerilenKm { get; set; }
        public decimal? AlinanUcret { get; set; }

        public bool? Durum { get; set; }

        public int? MusteriID { get; set; }

        
    }
}
