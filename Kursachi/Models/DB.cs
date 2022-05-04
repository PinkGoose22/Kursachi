using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Kursachi.Models
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual DbSet<DeliveryWays> DeliveryWays { get; set; }
        public virtual DbSet<PlaceDelivery> PlaceDelivery { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TimeOfDelivery> TimeOfDelivery { get; set; }
        public virtual DbSet<TypeOfContainer> TypeOfContainer { get; set; }
        public virtual DbSet<TypeOfProduct> TypeOfProduct { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(e => e.Delivery)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Delivery>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Delivery>()
                .HasMany(e => e.DeliveryProduct)
                .WithRequired(e => e.Delivery)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeliveryWays>()
                .HasMany(e => e.Delivery)
                .WithRequired(e => e.DeliveryWays)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlaceDelivery>()
                .HasMany(e => e.Delivery)
                .WithRequired(e => e.PlaceDelivery)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DeliveryProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Company)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeOfContainer>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TypeOfContainer>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.TypeOfContainer)
                .HasForeignKey(e => e.TypeOfProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeOfProduct>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.TypeOfProduct)
                .WillCascadeOnDelete(false);
        }
    }
}
