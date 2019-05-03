using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataTransferObject
{
    public class KullaniciTransferObject
    {
        /*

Herhangi bir sınıfta oluşturulan nesneyi ve özelliğini başka bir sınıfta kullanmak için kullandık.
iki farklı modelden gelen proporty'yi harmanlayarak bir model oluşturmak için DTO modelini kullandık.




*/

        [Key]
        public int KullaniciID { get; set; }

        [StringLength(50)]
        public string Adi { get; set; }

        [StringLength(50)]
        public string Soyadi { get; set; }

        public string Email { get; set; }

        public int? EhliyetYasi { get; set; }

        [StringLength(50)]
        public string Sifre { get; set; }

        public int? RolID { get; set; }

        public int? SirketID { get; set; }

        public virtual Roller Rol { get; set; }

        public virtual Sirket Sirket { get; set; }
    }
}
