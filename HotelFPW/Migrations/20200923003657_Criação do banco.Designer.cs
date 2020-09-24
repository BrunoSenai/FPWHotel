﻿// <auto-generated />
using System;
using HotelFPW.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelFPW.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200923003657_Criação do banco")]
    partial class Criaçãodobanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelFPW.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("HotelFPW.Models.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEndereco");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("HotelFPW.Models.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoIdEndereco")
                        .HasColumnType("int");

                    b.Property<string>("NomeFuncionario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFuncionario");

                    b.HasIndex("EnderecoIdEndereco");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("HotelFPW.Models.Hospedagem", b =>
                {
                    b.Property<int>("IdHospedagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<double>("PrecoFinal")
                        .HasColumnType("float");

                    b.Property<int?>("QuartoIdQuarto")
                        .HasColumnType("int");

                    b.HasKey("IdHospedagem");

                    b.HasIndex("ClienteIdCliente");

                    b.HasIndex("QuartoIdQuarto");

                    b.ToTable("Hospedagens");
                });

            modelBuilder.Entity("HotelFPW.Models.Quarto", b =>
                {
                    b.Property<int>("IdQuarto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumCamasCasal")
                        .HasColumnType("int");

                    b.Property<int>("NumCamasSolteiro")
                        .HasColumnType("int");

                    b.Property<int>("NumeroQuarto")
                        .HasColumnType("int");

                    b.Property<bool>("Ocupado")
                        .HasColumnType("bit");

                    b.Property<double>("PrecoDiaria")
                        .HasColumnType("float");

                    b.HasKey("IdQuarto");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("HotelFPW.Models.Servico", b =>
                {
                    b.Property<int>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoServico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorServico")
                        .HasColumnType("float");

                    b.HasKey("IdServico");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("HotelFPW.Models.ServicoHospedagem", b =>
                {
                    b.Property<int>("IdSH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HospedagemIdHospedagem")
                        .HasColumnType("int");

                    b.Property<int?>("ServicoIdServico")
                        .HasColumnType("int");

                    b.HasKey("IdSH");

                    b.HasIndex("HospedagemIdHospedagem");

                    b.HasIndex("ServicoIdServico");

                    b.ToTable("ServicosHospedagens");
                });

            modelBuilder.Entity("HotelFPW.Models.Funcionario", b =>
                {
                    b.HasOne("HotelFPW.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoIdEndereco");
                });

            modelBuilder.Entity("HotelFPW.Models.Hospedagem", b =>
                {
                    b.HasOne("HotelFPW.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteIdCliente");

                    b.HasOne("HotelFPW.Models.Quarto", "Quarto")
                        .WithMany()
                        .HasForeignKey("QuartoIdQuarto");
                });

            modelBuilder.Entity("HotelFPW.Models.ServicoHospedagem", b =>
                {
                    b.HasOne("HotelFPW.Models.Hospedagem", "Hospedagem")
                        .WithMany()
                        .HasForeignKey("HospedagemIdHospedagem");

                    b.HasOne("HotelFPW.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoIdServico");
                });
#pragma warning restore 612, 618
        }
    }
}
