﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_Grifo.contexto;

#nullable disable

namespace Sistema_Grifo.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    partial class AppDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Sistema_Grifo.Modelo.Diversos", b =>
                {
                    b.Property<int>("CustoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("valor_diversos")
                        .HasColumnType("float");

                    b.HasKey("CustoID");

                    b.ToTable("custosdiversos", (string)null);
                });

            modelBuilder.Entity("Sistema_Grifo.Modelo.MaoDeObra", b =>
                {
                    b.Property<int>("cargosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Nome_cargo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("valor_cargo")
                        .HasColumnType("float");

                    b.HasKey("cargosID");

                    b.ToTable("cargos", (string)null);
                });

            modelBuilder.Entity("Sistema_Grifo.Modelo.Material", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("material")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("valor_unidade")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("planilha", (string)null);
                });

            modelBuilder.Entity("Sistema_Grifo.Modelo.TabelaTemporaria", b =>
                {
                    b.Property<int>("temporarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<float>("valor")
                        .HasColumnType("float");

                    b.Property<float>("valorTotal")
                        .HasColumnType("float");

                    b.HasKey("temporarioID");

                    b.ToTable("descricao", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
