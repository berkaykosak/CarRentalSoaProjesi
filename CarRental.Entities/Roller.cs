namespace CarRental.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Roller")]
    public partial class Roller
    {
       

        [Key]
        public int RoleID { get; set; }

        [Column("Roller")]
        [StringLength(50)]
        public string RolAdi { get; set; }

       
    }
}
