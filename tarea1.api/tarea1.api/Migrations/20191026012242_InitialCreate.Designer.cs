﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tarea1.api.Data;

namespace tarea1.api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191026012242_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("tarea1.api.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("userDNI")
                        .HasColumnType("TEXT");

                    b.Property<string>("userDomicilio")
                        .HasColumnType("TEXT");

                    b.Property<string>("userFechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("userNombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("userTelefono")
                        .HasColumnType("TEXT");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
