﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace p26_crud_jugador.Migrations
{
    [DbContext(typeof(ContextoDatos))]
    [Migration("20231024172401_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Apariciones")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("TEXT");

                    b.Property<int>("Goles")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NoPlayera")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<string>("Posicion")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Jugadores");
                });
#pragma warning restore 612, 618
        }
    }
}
