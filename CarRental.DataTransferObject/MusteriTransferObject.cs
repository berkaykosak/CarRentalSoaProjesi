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

    class MusteriTransferObject
    {
        [Key]
        public int MusteriID { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }
        public int EhliyetYasi { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }
    }
}
