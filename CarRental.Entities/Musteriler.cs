using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    [Table("Musteriler")]
    public partial class Musteriler
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
