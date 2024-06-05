using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v021 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 540, DateTimeKind.Local).AddTicks(1951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 540, DateTimeKind.Local).AddTicks(2129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 485, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioGuardaChuva",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(6727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioGuardaChuva",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(6952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(5013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(5232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.AddColumn<string>(
                name: "LinkRedefinirSennha",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(2614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(2821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("1eef1a8d-86bf-4a9b-91ab-5054d462274d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e85f51d5-950a-4de0-b013-480c2a8ab59b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(1317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 538, DateTimeKind.Local).AddTicks(8651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 538, DateTimeKind.Local).AddTicks(8887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "FaqSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 538, DateTimeKind.Local).AddTicks(6723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "FaqSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 538, DateTimeKind.Local).AddTicks(6911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 536, DateTimeKind.Local).AddTicks(6348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 536, DateTimeKind.Local).AddTicks(6528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 536, DateTimeKind.Local).AddTicks(1361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 536, DateTimeKind.Local).AddTicks(1499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 534, DateTimeKind.Local).AddTicks(6612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 534, DateTimeKind.Local).AddTicks(6797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 532, DateTimeKind.Local).AddTicks(6601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 532, DateTimeKind.Local).AddTicks(6905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 532, DateTimeKind.Local).AddTicks(4359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 532, DateTimeKind.Local).AddTicks(4539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(701));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkRedefinirSennha",
                table: "Usuario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 540, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 485, DateTimeKind.Local).AddTicks(196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 540, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioGuardaChuva",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioGuardaChuva",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(2718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(3005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e85f51d5-950a-4de0-b013-480c2a8ab59b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("1eef1a8d-86bf-4a9b-91ab-5054d462274d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 539, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 538, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 538, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "FaqSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(3070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 538, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "FaqSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(3282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 538, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(2856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 536, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(3047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 536, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(7977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 536, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(8190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 536, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 534, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 534, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 532, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 532, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 532, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 19, 18, 14, 35, 532, DateTimeKind.Local).AddTicks(4539));
        }
    }
}
