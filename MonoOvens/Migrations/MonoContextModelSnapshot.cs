﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonoOvens.Models;

namespace MonoOvens.Migrations
{
    [DbContext(typeof(MonoContext))]
    partial class MonoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MonoOvens.Models.AssetCategoryMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetCategory");

                    b.HasKey("Id");

                    b.ToTable("AssetCategory");
                });

            modelBuilder.Entity("MonoOvens.Models.AssetMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetCategory");

                    b.Property<int>("AssetType");

                    b.Property<int>("ControllerType");

                    b.Property<int>("Controllers");

                    b.Property<string>("Format");

                    b.Property<string>("Handed");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Power");

                    b.Property<string>("PowerConsumption");

                    b.Property<string>("TrayHeight_inch");

                    b.Property<string>("TrayWidth_inch");

                    b.Property<int>("Trays");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("MonoOvens.Models.AssetTypeMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetType");

                    b.HasKey("Id");

                    b.ToTable("AssetType");
                });

            modelBuilder.Entity("MonoOvens.Models.ClientMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area");

                    b.Property<string>("City");

                    b.Property<string>("ClientName");

                    b.Property<string>("HOAddress1");

                    b.Property<string>("HOAddress2");

                    b.Property<string>("HOAddress3");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PostTown");

                    b.Property<string>("Postcode");

                    b.Property<string>("PrimaryContactName");

                    b.Property<string>("PrimaryContactNumber");

                    b.Property<string>("PrimaryEmail");

                    b.Property<string>("Region");

                    b.Property<string>("StoreAddress1");

                    b.Property<string>("StoreAddress2");

                    b.Property<string>("StoreCode");

                    b.Property<string>("StoreName");

                    b.Property<string>("StorePostcode");

                    b.Property<string>("Type");

                    b.Property<string>("Zone");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("MonoOvens.Models.ControllerModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthenticationCode");

                    b.Property<DateTime?>("ControllerDate");

                    b.Property<string>("FirmwareVersion");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("RecipeVersion");

                    b.Property<bool>("RemoteKill");

                    b.Property<string>("SerialNumber");

                    b.Property<TimeSpan?>("SevenDayTimer");

                    b.Property<string>("Skins");

                    b.Property<string>("SleepDelay");

                    b.Property<string>("SoftwareVersion");

                    b.Property<bool?>("Status");

                    b.Property<string>("Wallpaper");

                    b.HasKey("Id");

                    b.ToTable("Controller");
                });

            modelBuilder.Entity("MonoOvens.Models.ControllerTypeMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ControllerType");

                    b.HasKey("Id");

                    b.ToTable("ControllerType");
                });

            modelBuilder.Entity("MonoOvens.Models.CustomerMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area");

                    b.Property<string>("City");

                    b.Property<string>("CustomerName");

                    b.Property<string>("HOAddress1");

                    b.Property<string>("HOAddress2");

                    b.Property<string>("HOAddress3");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PostTown");

                    b.Property<string>("Postcode");

                    b.Property<string>("PrimaryContactName");

                    b.Property<string>("PrimaryContactNumber");

                    b.Property<string>("PrimaryEmail");

                    b.Property<string>("Region");

                    b.Property<string>("StoreAddress1");

                    b.Property<string>("StoreAddress2");

                    b.Property<string>("StoreCode");

                    b.Property<string>("StoreName");

                    b.Property<string>("StorePostcode");

                    b.Property<string>("Type");

                    b.Property<string>("Zone");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MonoOvens.Models.DealerMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DealerName");

                    b.Property<string>("DealerPhone");

                    b.Property<string>("DealerRegion");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("MonoOvens.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManufacturerId");

                    b.Property<string>("SupAddressLine1");

                    b.Property<string>("SupAddressLine2");

                    b.Property<string>("SupArea");

                    b.Property<string>("SupCity");

                    b.Property<string>("SupEmail");

                    b.Property<string>("SupName");

                    b.Property<decimal?>("SupPhone");

                    b.Property<string>("SupState");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("MonoOvens.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId");

                    b.Property<string>("DealerId");

                    b.Property<string>("ManufacturerId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("OrderId");

                    b.Property<string>("OrderedQuantity");

                    b.Property<string>("ProductId");

                    b.Property<string>("ShippedDate");

                    b.Property<string>("ShippedQuantity");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MonoOvens.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InverseManufacturerId");

                    b.Property<string>("ManufacturerId");

                    b.Property<string>("ProductCategoryId");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductId");

                    b.Property<string>("ProductSubCategoryId");

                    b.Property<string>("ProductTypeId");

                    b.HasKey("Id");

                    b.HasIndex("InverseManufacturerId")
                        .IsUnique()
                        .HasFilter("[InverseManufacturerId] IS NOT NULL");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("MonoOvens.Models.RoleMaster", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");


                    b.ToTable("RoleMaster");

                    b.HasDiscriminator().HasValue("RoleMaster");
                });

            modelBuilder.Entity("MonoOvens.Models.UserMaster", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("AccessRole");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.ToTable("UserMaster");

                    b.HasDiscriminator().HasValue("UserMaster");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MonoOvens.Models.Product", b =>
                {
                    b.HasOne("MonoOvens.Models.Product", "InverseManufacturer")
                        .WithOne("Manufacturer")
                        .HasForeignKey("MonoOvens.Models.Product", "InverseManufacturerId");
                });
#pragma warning restore 612, 618
        }
    }
}
