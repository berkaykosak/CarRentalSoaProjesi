using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRental.DataAccessLayer
{
    public class CarRentalContex : DbContext
    {
        public CarRentalContex()
            : base("name=CarRentalSoa")
        { }


        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<KiralikBilgi> Kiralik { get; set; }
        public virtual DbSet<Kullanicilar> Kullanici { get; set; }
        public virtual DbSet<Musteriler> Musteri { get; set; }
        public virtual DbSet<Roller> Role { get; set; }
        public virtual DbSet<Sirket> Sirket { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arac>()
                .Property(e => e.GunlukKiralikFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KiralikBilgi>()
                .Property(e => e.AlinanUcret)
                .HasPrecision(19, 4);
        }

    }
}
    
