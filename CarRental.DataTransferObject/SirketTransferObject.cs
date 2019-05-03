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
    class SirketTransferObject
    {
        [Key]
        public int SirketID { get; set; }

        public string SirketAdi { get; set; }

        public string SirketSehir { get; set; }

        public string SirketAdres { get; set; }

        public int SirketAracSayisi { get; set; }
    }
}
