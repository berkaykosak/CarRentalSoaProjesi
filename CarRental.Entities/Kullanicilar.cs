namespace CarRental.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanicilar")]
    public partial class Kullanicilar
    {   
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
