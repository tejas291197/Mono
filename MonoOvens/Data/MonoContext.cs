using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MonoOvens.Models;

namespace MonoOvens.Models
{
     public partial class MonoContext : IdentityDbContext
    // public partial class MonoOvenContext : IdentityDbContext<IdentityUser>
    {
        

        public MonoContext(DbContextOptions<MonoContext> options)
            : base(options)
        {
        }
        public virtual DbSet<UserMaster> Users { get; set; }
        public virtual DbSet<ClientMaster> Client { get; set; }
        public virtual DbSet<AssetTypeMaster> AssetType { get; set; }
        public virtual DbSet<AssetCategoryMaster> AssetCategory { get; set; }
        public virtual DbSet<ControllerTypeMaster> ControllerType { get; set; }
        public virtual DbSet<ControllerModule> Controller { get; set; }
        public virtual DbSet<DealerMaster> Dealers { get; set; }
        public virtual DbSet<AssetMaster> Assets  { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
         
        public virtual DbSet<Product> Product { get; set; }
         
        public DbSet<MonoOvens.Models.RoleMaster> RoleMaster { get; set; }
         
        public DbSet<MonoOvens.Models.CustomerMaster> Customers { get; set; }

        // new models class added.
        public DbSet<MonoOvens.Models.StoreMaster> Stores { get; set; }
        public DbSet<MonoOvens.Models.StoreGroupMaster> StoreGroups { get; set; }
        public DbSet<ImporterMaster> Importers { get; set; }




        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=DESKTOP-1BB02P8\\SQLEXPRESS01;Database=Mono;Trusted_Connection=True;");
        //            }
        //        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Client>(entity =>
        //    {
        //        entity.Property(e => e.ClientId)
        //            .HasMaxLength(10)
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.Area).HasMaxLength(10);

        //        entity.Property(e => e.City)
        //            .IsRequired()
        //            .HasMaxLength(10);

        //        entity.Property(e => e.ClientAddressLine1)
        //            .HasColumnName("ClientAddressLine_1")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.ClientAddressLine2)
        //            .HasColumnName("ClientAddressLine_2")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.ClientAddressLine3)
        //            .HasColumnName("ClientAddressLine_3")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.DealerId)
        //            .HasColumnName("DelearID")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.HomePostcode).HasMaxLength(10);

        //        entity.Property(e => e.PostTown).HasMaxLength(10);

        //        entity.Property(e => e.PrimaryContactName).HasMaxLength(10);

        //        entity.Property(e => e.PrimaryContactNumber)
        //            .IsRequired()
        //            .HasMaxLength(10);

        //        entity.Property(e => e.PrimaryEmail).HasMaxLength(10);

        //        entity.Property(e => e.Region).HasMaxLength(10);

        //        entity.Property(e => e.StoreAddressLine1)
        //            .HasColumnName("StoreAddressLine_1")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.StoreAddressLine2)
        //            .HasColumnName("StoreAddressLine_2")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.StoreName).HasMaxLength(10);

        //        entity.Property(e => e.StorePostcode).HasMaxLength(10);

        //        entity.Property(e => e.Storecode).HasMaxLength(10);

        //        entity.Property(e => e.Type)
        //            .IsRequired()
        //            .HasMaxLength(10);

        //        entity.Property(e => e.Zone).HasMaxLength(10);
        //    });

        //    modelBuilder.Entity<ControllerModule>(entity =>
        //    {
        //        entity.HasKey(e => e.SerialNumber);

        //        entity.Property(e => e.SerialNumber).HasColumnType("numeric(18, 0)");

        //        entity.Property(e => e.FirmwareVersion).HasMaxLength(10);

        //        entity.Property(e => e.RecipeVersion).HasMaxLength(10);

        //        entity.Property(e => e.Skins).HasMaxLength(10);

        //        entity.Property(e => e.SleepDelay).HasMaxLength(10);

        //        entity.Property(e => e.SoftwareVersion).HasMaxLength(10);

        //        entity.Property(e => e.Wallpaper)
        //            .HasColumnName("wallpaper")
        //            .HasMaxLength(10);
        //    });

        //    modelBuilder.Entity<Dealer>(entity =>
        //    {
        //        entity.Property(e => e.DealerId)
        //            .HasMaxLength(10)
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.DealerAddressLine1)
        //            .HasColumnName("Dealer_AddressLine1")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.DealerAddressLine2)
        //            .HasColumnName("Dealer_AddressLine2")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.DealerArea)
        //            .HasColumnName("Dealer_Area")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.DealerCity)
        //            .HasColumnName("Dealer_City")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.DealerCountry)
        //            .HasColumnName("Dealer_Country")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.DealerEmail).HasColumnName("Dealer_Email");

        //        entity.Property(e => e.DealerName)
        //            .HasColumnName("Dealer_Name")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.DealerPhone)
        //            .HasColumnName("Dealer_Phone")
        //            .HasColumnType("numeric(18, 0)");

        //        entity.Property(e => e.DealerState)
        //            .HasColumnName("Dealer_State")
        //            .HasMaxLength(10);
        //    });

        //    modelBuilder.Entity<Manufacturer>(entity =>
        //    {
        //        entity.Property(e => e.ManufacturerId)
        //            .HasMaxLength(10)
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.SupAddressLine1)
        //            .HasColumnName("Sup_AddressLine1")
        //            .HasMaxLength(50);

        //        entity.Property(e => e.SupAddressLine2)
        //            .HasColumnName("Sup_AddressLine2")
        //            .HasMaxLength(50);

        //        entity.Property(e => e.SupArea)
        //            .HasColumnName("Sup_Area")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.SupCity)
        //            .HasColumnName("Sup_City")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.SupEmail)
        //            .HasColumnName("Sup_Email")
        //            .HasMaxLength(50);

        //        entity.Property(e => e.SupName)
        //            .HasColumnName("Sup_Name")
        //            .HasMaxLength(10);

        //        entity.Property(e => e.SupPhone)
        //            .HasColumnName("Sup_Phone")
        //            .HasColumnType("numeric(18, 0)");

        //        entity.Property(e => e.SupState)
        //            .HasColumnName("Sup_State")
        //            .HasMaxLength(10);
        //    });

        //    modelBuilder.Entity<Order>(entity =>
        //    {
        //        entity.Property(e => e.OrderId)
        //            .HasMaxLength(10)
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.ClientId)
        //            .IsRequired()
        //            .HasMaxLength(10);

        //        entity.Property(e => e.DealerId)
        //            .IsRequired()
        //            .HasMaxLength(10);

        //        entity.Property(e => e.ManufacturerId)
        //            .IsRequired()
        //            .HasMaxLength(10);

        //        entity.Property(e => e.OrderedQuantity).HasMaxLength(10);

        //        entity.Property(e => e.ProductId)
        //            .IsRequired()
        //            .HasMaxLength(10);

        //        entity.Property(e => e.ShippedDate).HasMaxLength(10);

        //        entity.Property(e => e.ShippedQuantity).HasMaxLength(10);
        //    });

        //    modelBuilder.Entity<Product>(entity =>
        //    {
        //        entity.HasKey(e => e.ManufacturerId);

        //        entity.Property(e => e.ManufacturerId)
        //            .HasMaxLength(10)
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.ProductCategoryId).HasMaxLength(10);

        //        entity.Property(e => e.ProductDescription).HasMaxLength(50);

        //        entity.Property(e => e.ProductId)
        //            .IsRequired()
        //            .HasMaxLength(10);

        //        entity.Property(e => e.ProductSubCategoryId).HasMaxLength(10);

        //        entity.Property(e => e.ProductTypeId).HasMaxLength(10);

        //        entity.HasOne(d => d.Manufacturer)
        //            .WithOne(p => p.InverseManufacturer)
        //            .HasForeignKey<Product>(d => d.ManufacturerId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Product_Product");
        //    });
        //}
    }
}
