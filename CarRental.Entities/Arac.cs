namespace CarRental.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arac")]
    public partial class Arac
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

        [Column(TypeName = "money")]
        public decimal? GunlukKiralikFiyat { get; set; }

        public int? SirketID{ get; set; }

        public bool? Rezerve { get; set; }

        public virtual Sirket Sirket { get; set; }

        
    }
}
