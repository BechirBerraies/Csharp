﻿// <auto-generated />
using System;
using Croissant_Rouge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Croissant_Rouge.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20231108154555_UserMigration")]
    partial class UserMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Croissant_Rouge.Models.Donation", b =>
                {
                    b.Property<int>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Picture")
                        .HasColumnType("longtext");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("DonationId");

                    b.HasIndex("UserId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("Croissant_Rouge.Models.Money", b =>
                {
                    b.Property<int>("MoneyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MoneyId");

                    b.HasIndex("UserId");

                    b.ToTable("Moneys");
                });

            modelBuilder.Entity("Croissant_Rouge.Models.Shipment", b =>
                {
                    b.Property<int>("ShipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DonationId")
                        .HasColumnType("int");

                    b.Property<int>("ShipStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ShipmentId");

                    b.HasIndex("DonationId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("Croissant_Rouge.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Croissant_Rouge.Models.Donation", b =>
                {
                    b.HasOne("Croissant_Rouge.Models.User", "Donner")
                        .WithMany("MyDonations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donner");
                });

            modelBuilder.Entity("Croissant_Rouge.Models.Money", b =>
                {
                    b.HasOne("Croissant_Rouge.Models.User", "Giver")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Giver");
                });

            modelBuilder.Entity("Croissant_Rouge.Models.Shipment", b =>
                {
                    b.HasOne("Croissant_Rouge.Models.Donation", "Donation")
                        .WithOne("Shipment")
                        .HasForeignKey("Croissant_Rouge.Models.Shipment", "DonationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Croissant_Rouge.Models.User", "Shipper")
                        .WithMany("Shipments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donation");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("Croissant_Rouge.Models.Donation", b =>
                {
                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("Croissant_Rouge.Models.User", b =>
                {
                    b.Navigation("MyDonations");

                    b.Navigation("Shipments");
                });
#pragma warning restore 612, 618
        }
    }
}
