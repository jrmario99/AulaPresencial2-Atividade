﻿// <auto-generated />
using System;
using AtividadeAula2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AtividadeAula2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AtividadeAula2.Models.Casos", b =>
                {
                    b.Property<int>("CasosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sigla")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCasos")
                        .HasColumnType("int");

                    b.Property<int>("mortes")
                        .HasColumnType("int");

                    b.Property<int>("recuperados")
                        .HasColumnType("int");

                    b.Property<int>("suspeitos")
                        .HasColumnType("int");

                    b.HasKey("CasosId");

                    b.ToTable("Casos");
                });
#pragma warning restore 612, 618
        }
    }
}