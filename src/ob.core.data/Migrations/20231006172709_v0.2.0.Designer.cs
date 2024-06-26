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
    [Migration("20231006172709_v0.2.0")]
    partial class v020
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ob.core.domain.Entities.CarteiraCashBackLancamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarteiraCashbackId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2998));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2699));

                    b.Property<DateTime?>("DataExpiracao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SaldoAnterior")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoLancamento")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ValorUtilizado")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarteiraCashbackId");

                    b.ToTable("CarteiraCashBackLancamentos");
                });

            modelBuilder.Entity("ob.core.domain.Entities.CarteiraCashback", b =>
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

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(701));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(470));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SaldoAtual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("CarteiraCashback");
                });

            modelBuilder.Entity("ob.core.domain.Entities.Cotacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3216));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3012));

                    b.HasKey("Id");

                    b.ToTable("Cotacao");
                });

            modelBuilder.Entity("ob.core.domain.Entities.CotacaoDetalhes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CotacaoId")
                        .HasColumnType("int");

                    b.Property<string>("CpfOuCnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<bool>("MotoristaEntre18E15Anos")
                        .HasColumnType("bit");

                    b.Property<string>("NomeMotorista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrincipalMotoristaVeiculo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CotacaoId")
                        .IsUnique();

                    b.ToTable("CotacaoDetalhes");
                });

            modelBuilder.Entity("ob.core.domain.Entities.CotacaoVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnoModelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CepVeiculoPerNoite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CotacaoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAplicacaoBlindagem")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataAplicacaoKitGas")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(8190));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(7977));

                    b.Property<string>("MarcaVeiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeloVeiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroPlaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PossuiBlindagem")
                        .HasColumnType("bit");

                    b.Property<bool>("PossuiKitGas")
                        .HasColumnType("bit");

                    b.Property<decimal?>("ValorAproximadoBlindagem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ValorAproximadoKitGas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("VeiculoZeroKm")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CotacaoId")
                        .IsUnique();

                    b.ToTable("CotacaoVeiculo");
                });

            modelBuilder.Entity("ob.core.domain.Entities.EmailConfiguracao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(3047));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(2856));

                    b.Property<string>("SmptEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SmptPorta")
                        .HasColumnType("int");

                    b.Property<string>("SmptSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmtpServidor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmailConfiguracao");
                });

            modelBuilder.Entity("ob.core.domain.Entities.FaqSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(3282));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(3070));

                    b.Property<string>("Pergunta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SistemaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SistemaId");

                    b.ToTable("FaqSistema");
                });

            modelBuilder.Entity("ob.core.domain.Entities.ParametrosDeSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ambiente")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5621));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5322));

                    b.Property<int>("SistemaId")
                        .HasColumnType("int");

                    b.Property<string>("UrlApi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SistemaId");

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
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8802));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8504));

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
                        .HasDefaultValue(new Guid("e85f51d5-950a-4de0-b013-480c2a8ab59b"));

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(236));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9));

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

                    b.Property<Guid>("CodigoIndicacao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(3005));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(2718));

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LimiteIndicacao")
                        .HasColumnType("int");

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

            modelBuilder.Entity("ob.core.domain.Entities.UsuarioGuardaChuva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4848));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4585));

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<int>("NivelIndicacao")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioIndicacaoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioIndicadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioIndicacaoId");

                    b.ToTable("UsuarioGuardaChuva");
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
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 485, DateTimeKind.Local).AddTicks(196));

                    b.Property<DateTime>("DataDeCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9993));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
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

            modelBuilder.Entity("ob.core.domain.Entities.CarteiraCashBackLancamentos", b =>
                {
                    b.HasOne("ob.core.domain.Entities.CarteiraCashback", "CarteiraCashback")
                        .WithMany("CarteiraCashBackLancamentos")
                        .HasForeignKey("CarteiraCashbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarteiraCashback");
                });

            modelBuilder.Entity("ob.core.domain.Entities.CarteiraCashback", b =>
                {
                    b.HasOne("ob.core.domain.Entities.Usuario", "Usuario")
                        .WithOne("CarteiraCashback")
                        .HasForeignKey("ob.core.domain.Entities.CarteiraCashback", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ob.core.domain.Entities.CotacaoDetalhes", b =>
                {
                    b.HasOne("ob.core.domain.Entities.Cotacao", "Cotacao")
                        .WithOne("CotacaoDetalhes")
                        .HasForeignKey("ob.core.domain.Entities.CotacaoDetalhes", "CotacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cotacao");
                });

            modelBuilder.Entity("ob.core.domain.Entities.CotacaoVeiculo", b =>
                {
                    b.HasOne("ob.core.domain.Entities.Cotacao", "Cotacao")
                        .WithOne("CotacaoVeiculo")
                        .HasForeignKey("ob.core.domain.Entities.CotacaoVeiculo", "CotacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cotacao");
                });

            modelBuilder.Entity("ob.core.domain.Entities.FaqSistema", b =>
                {
                    b.HasOne("ob.core.domain.Entities.Sistema", "Sistema")
                        .WithMany("FaqSistemas")
                        .HasForeignKey("SistemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sistema");
                });

            modelBuilder.Entity("ob.core.domain.Entities.ParametrosDeSistema", b =>
                {
                    b.HasOne("ob.core.domain.Entities.Sistema", "Sistema")
                        .WithMany("ParametrosDeSistemas")
                        .HasForeignKey("SistemaId")
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

            modelBuilder.Entity("ob.core.domain.Entities.UsuarioGuardaChuva", b =>
                {
                    b.HasOne("ob.core.domain.Entities.Usuario", "UsuarioIndicacao")
                        .WithMany("UsuariosGuardaChuva")
                        .HasForeignKey("UsuarioIndicacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioIndicacao");
                });

            modelBuilder.Entity("ob.core.domain.Entities.CarteiraCashback", b =>
                {
                    b.Navigation("CarteiraCashBackLancamentos");
                });

            modelBuilder.Entity("ob.core.domain.Entities.Cotacao", b =>
                {
                    b.Navigation("CotacaoDetalhes")
                        .IsRequired();

                    b.Navigation("CotacaoVeiculo")
                        .IsRequired();
                });

            modelBuilder.Entity("ob.core.domain.Entities.PerfilUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ob.core.domain.Entities.Sistema", b =>
                {
                    b.Navigation("FaqSistemas");

                    b.Navigation("ParametrosDeSistemas");
                });

            modelBuilder.Entity("ob.core.domain.Entities.Usuario", b =>
                {
                    b.Navigation("CarteiraCashback");

                    b.Navigation("UsuariosGuardaChuva");
                });
#pragma warning restore 612, 618
        }
    }
}
