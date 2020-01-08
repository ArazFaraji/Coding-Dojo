﻿// <auto-generated />
using System;
using ActivityCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ActivityCenter.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20191216171604_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ActivityCenter.Models.Actividad", b =>
                {
                    b.Property<int>("ActividadId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("DurationInt");

                    b.Property<string>("DurationString")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("ActividadId");

                    b.HasIndex("UserId");

                    b.ToTable("Actividads");
                });

            modelBuilder.Entity("ActivityCenter.Models.GuestList", b =>
                {
                    b.Property<int>("GuestListId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActividadId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("GuestListId");

                    b.HasIndex("ActividadId");

                    b.HasIndex("UserId");

                    b.ToTable("GuestLists");
                });

            modelBuilder.Entity("ActivityCenter.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ActivityCenter.Models.Actividad", b =>
                {
                    b.HasOne("ActivityCenter.Models.User", "Creator")
                        .WithMany("Planned")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ActivityCenter.Models.GuestList", b =>
                {
                    b.HasOne("ActivityCenter.Models.Actividad", "Actividad")
                        .WithMany("Guests")
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ActivityCenter.Models.User", "Guest")
                        .WithMany("Attending")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
