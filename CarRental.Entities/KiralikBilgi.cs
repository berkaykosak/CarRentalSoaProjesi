namespace CarRental.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KiralikBilgi")]
    public partial class KiralikBilgi
    {
        [Key]
        public int KiralikID { get; set; }

        public int? AracID { get; set; }

        public DateTime? KiralamaTarihi { get; set; }

        public DateTime? GeriVermeTarihi { get; set; }

        public long? VerilenKm { get; set; }

        [Column(TypeName = "money")]
        public decimal? AlinanUcret { get; set; }

        public bool? Durum { get; set; }

        public int? MusteriID { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Musteriler Musteri { get; set; }
    }
}
