﻿// <auto-generated />
using System;
using AplicacaoWebMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AplicacaoWebMvc.Migrations
{
    [DbContext(typeof(AplicacaoWebMvcContext))]
    [Migration("20200319010611_CriandoNovasClasses")]
    partial class CriandoNovasClasses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AplicacaoWebMvc.Models.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Nome");

                    b.Property<int>("PessoaId");

                    b.Property<string>("TelefoneFixo");

                    b.Property<string>("TelefoneMovel");

                    b.HasKey("ContatoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("AplicacaoWebMvc.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<int>("PessoaId");

                    b.HasKey("EnderecoId");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("AplicacaoWebMvc.Models.Fichario", b =>
                {
                    b.Property<int>("FicharioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("FicharioId");

                    b.ToTable("Fichario");
                });

            modelBuilder.Entity("AplicacaoWebMvc.Models.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired();

                    b.Property<string>("CidadeDeNascimento");

                    b.Property<string>("Conjugue");

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<int>("EstadoCivil");

                    b.Property<int>("FicharioId");

                    b.Property<string>("Nacionalidade");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NomeDaMae");

                    b.Property<string>("NomeDoPai");

                    b.Property<string>("Observacao");

                    b.Property<int>("Sexo");

                    b.HasKey("PessoaId");

                    b.HasIndex("FicharioId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("AplicacaoWebMvc.Models.RegistroDeDizimo", b =>
                {
                    b.Property<int>("RegistroDeDizimoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int?>("PessoaId");

                    b.Property<int>("Status");

                    b.Property<double>("Valor");

                    b.HasKey("RegistroDeDizimoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("RegistroDeDizimo");
                });

            modelBuilder.Entity("AplicacaoWebMvc.Models.Contato", b =>
                {
                    b.HasOne("AplicacaoWebMvc.Models.Pessoa", "Pessoa")
                        .WithMany("Contatos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AplicacaoWebMvc.Models.Endereco", b =>
                {
                    b.HasOne("AplicacaoWebMvc.Models.Pessoa", "pessoa")
                        .WithOne("Endereco")
                        .HasForeignKey("AplicacaoWebMvc.Models.Endereco", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AplicacaoWebMvc.Models.Pessoa", b =>
                {
                    b.HasOne("AplicacaoWebMvc.Models.Fichario", "Fichario")
                        .WithMany("ListaDePessoa")
                        .HasForeignKey("FicharioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AplicacaoWebMvc.Models.RegistroDeDizimo", b =>
                {
                    b.HasOne("AplicacaoWebMvc.Models.Pessoa", "Pessoa")
                        .WithMany("Registro")
                        .HasForeignKey("PessoaId");
                });
#pragma warning restore 612, 618
        }
    }
}
