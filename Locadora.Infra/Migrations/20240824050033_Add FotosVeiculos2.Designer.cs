﻿// <auto-generated />
using Locadora.Infra.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Locadora.Infra.Migrations
{
    [DbContext(typeof(LocadoraDbContext))]
    [Migration("20240824050033_Add FotosVeiculos2")]
    partial class AddFotosVeiculos2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Locadora.Dominio.ModuloGrupoVeiculos.GrupoVeiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("varchar");

                    b.HasKey("Id");

                    b.ToTable("TBGrupoVeiculos", (string)null);
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloVeiculos.Veiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Id")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CapacidadeTanque")
                        .HasColumnType("int")
                        .HasColumnName("CapacidadeTanque");

                    b.Property<byte[]>("Fotos")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(max)")
                        .HasDefaultValue(new byte[0])
                        .HasColumnName("Fotos");

                    b.Property<int>("GrupoVeiculosId")
                        .HasColumnType("int")
                        .HasColumnName("GrupoVeiculosId");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Marca");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Modelo");

                    b.Property<int>("TipoCombustivel")
                        .HasColumnType("int")
                        .HasColumnName("TipoCombustivel");

                    b.HasKey("Id");

                    b.HasIndex("GrupoVeiculosId");

                    b.ToTable("TBVeiculos", (string)null);
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloVeiculos.Veiculos", b =>
                {
                    b.HasOne("Locadora.Dominio.ModuloGrupoVeiculos.GrupoVeiculos", "GrupoVeiculos")
                        .WithMany("Veiculos")
                        .HasForeignKey("GrupoVeiculosId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GrupoVeiculos");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloGrupoVeiculos.GrupoVeiculos", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
