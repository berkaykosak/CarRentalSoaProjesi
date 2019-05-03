using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataTransferObject
{
    /*

Herhangi bir sınıfta oluşturulan nesneyi ve özelliğini başka bir sınıfta kullanmak için kullandık.
iki farklı modelden gelen proporty'yi harmanlayarak bir model oluşturmak için DTO modelini kullandık.




*/
    class RollerTransferObject
    {
        [Key]
        public int RoleID { get; set; }

        [Column("Roller")]
        [StringLength(50)]
        public string RolAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kullanicilar> Kullanici { get; set; }
    }
}
