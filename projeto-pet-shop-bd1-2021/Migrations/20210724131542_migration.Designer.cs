﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using projeto_pet_shop_bd1_2021.Data;

namespace projeto_pet_shop_bd1_2021.Migrations
{
    [DbContext(typeof(PetShopContext))]
    [Migration("20210724131542_migration")]
    partial class migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Animais.Animal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("ClienteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<long>("RacaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("RacaId");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Animais.Raca", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Caracteristica")
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<long>("TipoAnimalId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TipoAnimalId")
                        .IsUnique();

                    b.ToTable("Raca");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Animais.TipoAnimal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TipoAnimal");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Pessoas.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("PessoaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Pessoas.Funcionario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("PessoaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Pessoas.Pessoa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.Atendimento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("AnimalId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("FuncionarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId")
                        .IsUnique();

                    b.HasIndex("FuncionarioId")
                        .IsUnique();

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.Servico", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Custo")
                        .HasColumnType("numeric");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.ServicoAtendimento", b =>
                {
                    b.Property<long>("AtendimentoId")
                        .HasColumnType("bigint");

                    b.Property<long>("ServicoId")
                        .HasColumnType("bigint");

                    b.HasIndex("AtendimentoId")
                        .IsUnique();

                    b.HasIndex("ServicoId")
                        .IsUnique();

                    b.ToTable("ServicoAtendimento");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Animais.Animal", b =>
                {
                    b.HasOne("projeto_pet_shop_bd1_2021.Models.Pessoas.Cliente", "Cliente")
                        .WithOne()
                        .HasForeignKey("projeto_pet_shop_bd1_2021.Models.Animais.Animal", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projeto_pet_shop_bd1_2021.Models.Animais.Raca", "Raca")
                        .WithMany()
                        .HasForeignKey("RacaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Raca");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Animais.Raca", b =>
                {
                    b.HasOne("projeto_pet_shop_bd1_2021.Models.Animais.TipoAnimal", "TipoAnimal")
                        .WithOne()
                        .HasForeignKey("projeto_pet_shop_bd1_2021.Models.Animais.Raca", "TipoAnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoAnimal");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Pessoas.Cliente", b =>
                {
                    b.HasOne("projeto_pet_shop_bd1_2021.Models.Pessoas.Pessoa", "Pessoa")
                        .WithOne()
                        .HasForeignKey("projeto_pet_shop_bd1_2021.Models.Pessoas.Cliente", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.Pessoas.Funcionario", b =>
                {
                    b.HasOne("projeto_pet_shop_bd1_2021.Models.Pessoas.Pessoa", "Pessoa")
                        .WithOne()
                        .HasForeignKey("projeto_pet_shop_bd1_2021.Models.Pessoas.Funcionario", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.Atendimento", b =>
                {
                    b.HasOne("projeto_pet_shop_bd1_2021.Models.Animais.Animal", "Animal")
                        .WithOne()
                        .HasForeignKey("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.Atendimento", "AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projeto_pet_shop_bd1_2021.Models.Pessoas.Funcionario", "Funcionario")
                        .WithOne()
                        .HasForeignKey("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.Atendimento", "FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.ServicoAtendimento", b =>
                {
                    b.HasOne("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.Atendimento", "Atendimento")
                        .WithOne()
                        .HasForeignKey("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.ServicoAtendimento", "AtendimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.Servico", "Servico")
                        .WithOne()
                        .HasForeignKey("projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos.ServicoAtendimento", "ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atendimento");

                    b.Navigation("Servico");
                });
#pragma warning restore 612, 618
        }
    }
}