﻿// <auto-generated />
using System;
using MarianaTestes.InfraData.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarianaTestes.InfraData.Orm.Migrations
{
    [DbContext(typeof(MarianaTestesDbContext))]
    [Migration("20230727024859_Add-TbTeste")]
    partial class AddTbTeste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloDisciplina.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBDisciplina", (string)null);
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloMateria.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Serie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("TBMateria", (string)null);
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloQuestao.Alternativa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EhCorreta")
                        .HasColumnType("bit");

                    b.Property<int>("QuestaoId")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("QuestaoId");

                    b.ToTable("TBAlternativa", (string)null);
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloQuestao.Questao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.ToTable("TBQuestao", (string)null);
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloTeste.Teste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataTeste")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int>("QtdQuestoes")
                        .HasColumnType("int");

                    b.Property<bool>("Recuperacao")
                        .HasColumnType("bit");

                    b.Property<int?>("Serie")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("TBTeste", (string)null);
                });

            modelBuilder.Entity("QuestaoTeste", b =>
                {
                    b.Property<int>("QuestoesId")
                        .HasColumnType("int");

                    b.Property<int>("TesteId")
                        .HasColumnType("int");

                    b.HasKey("QuestoesId", "TesteId");

                    b.HasIndex("TesteId");

                    b.ToTable("TBTeste_TBQuestao", (string)null);
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloMateria.Materia", b =>
                {
                    b.HasOne("MarianaTestes.Dominio.ModuloDisciplina.Disciplina", "Disciplina")
                        .WithMany("Materias")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBMateria_TBDisciplina");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloQuestao.Alternativa", b =>
                {
                    b.HasOne("MarianaTestes.Dominio.ModuloQuestao.Questao", "Questao")
                        .WithMany("Alternativas")
                        .HasForeignKey("QuestaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TBAlternativa_TBQuestao");

                    b.Navigation("Questao");
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloQuestao.Questao", b =>
                {
                    b.HasOne("MarianaTestes.Dominio.ModuloMateria.Materia", "Materia")
                        .WithMany("Questoes")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBQuestao_TBMateria");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloTeste.Teste", b =>
                {
                    b.HasOne("MarianaTestes.Dominio.ModuloDisciplina.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBTeste_TBDisciplina");

                    b.HasOne("MarianaTestes.Dominio.ModuloMateria.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("FK_TBTeste_TBMateria");

                    b.Navigation("Disciplina");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("QuestaoTeste", b =>
                {
                    b.HasOne("MarianaTestes.Dominio.ModuloQuestao.Questao", null)
                        .WithMany()
                        .HasForeignKey("QuestoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarianaTestes.Dominio.ModuloTeste.Teste", null)
                        .WithMany()
                        .HasForeignKey("TesteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloDisciplina.Disciplina", b =>
                {
                    b.Navigation("Materias");
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloMateria.Materia", b =>
                {
                    b.Navigation("Questoes");
                });

            modelBuilder.Entity("MarianaTestes.Dominio.ModuloQuestao.Questao", b =>
                {
                    b.Navigation("Alternativas");
                });
#pragma warning restore 612, 618
        }
    }
}
