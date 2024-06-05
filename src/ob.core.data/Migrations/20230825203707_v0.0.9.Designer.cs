﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ob.core.data.Context;

#nullable disable

namespace ob.core.data.Migrations
{
    [DbContext(typeof(ObCoreContext))]
    [Migration("20230825203707_v0.0.9")]
    partial class v009
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ob.core.domain.Entities.ParametrosDeSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 625, DateTimeKind.Local).AddTicks(7351));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 625, DateTimeKind.Local).AddTicks(7062));

                    b.Property<int>("SistemaId")
                        .HasColumnType("int");

                    b.Property<string>("UrlApi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SistemaId")
                        .IsUnique();

                    b.ToTable("ParametrosDeSistema");
                });

            modelBuilder.Entity("ob.core.domain.Entities.PerfilUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(2080));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(1883));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoDeUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PerfilUsuario");
                });

            modelBuilder.Entity("ob.core.domain.Entities.Sistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<Guid>("ChaveDeAcesso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("c3a4ca7c-0624-48c2-be65-ef7da9a4ce22"));

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(3982));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(3684));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("ob.core.domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPFCNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(7471));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(7172));

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerfilUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoDePlano")
                        .HasColumnType("int");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerfilUsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ob.core.domain.Entities.UsuarioLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AceiteTermo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 628, DateTimeKind.Local).AddTicks(3387));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 25, 17, 37, 7, 628, DateTimeKind.Local).AddTicks(3189));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoSeguro")
                        .HasColumnType("int");

                    b.Property<bool>("UsuarioJaCadastrado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("UsuarioLead");
                });

            modelBuilder.Entity("ob.core.domain.Entities.ParametrosDeSistema", b =>
                {
                    b.HasOne("ob.core.domain.Entities.Sistema", "Sistema")
                        .WithOne("ParametrosDeSistema")
                        .HasForeignKey("ob.core.domain.Entities.ParametrosDeSistema", "SistemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sistema");
                });

            modelBuilder.Entity("ob.core.domain.Entities.Usuario", b =>
                {
                    b.HasOne("ob.core.domain.Entities.PerfilUsuario", "PerfilUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfilUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PerfilUsuario");
                });

            modelBuilder.Entity("ob.core.domain.Entities.PerfilUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ob.core.domain.Entities.Sistema", b =>
                {
                    b.Navigation("ParametrosDeSistema")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
