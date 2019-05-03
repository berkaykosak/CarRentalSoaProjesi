namespace CarRental.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sirket")]
    public partial class Sirket
    {

        [Key]
        public int SirketID { get; set; }

        public string SirketAdi { get; set; }

        public string SirketSehir { get; set; }

        public string SirketAdres { get; set; }

        public int SirketAracSayisi { get; set; }

       
    }
}
