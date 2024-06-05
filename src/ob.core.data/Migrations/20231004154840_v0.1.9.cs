using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v019 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(7386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 741, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(7565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 741, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(2160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(2365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("ab2fd76a-d469-4180-b979-e4d07f5b02f3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("66fe0173-a431-4f80-b25e-1c45d3509f3a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(8932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(9144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(7123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 739, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(7317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(6335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(6532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(1068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(1207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 148, DateTimeKind.Local).AddTicks(8276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 736, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 148, DateTimeKind.Local).AddTicks(8460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 736, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorUtilizado",
                table: "CarteiraCashBackLancamentos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SaldoAnterior",
                table: "CarteiraCashBackLancamentos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpiracao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 147, DateTimeKind.Local).AddTicks(989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 147, DateTimeKind.Local).AddTicks(1293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 146, DateTimeKind.Local).AddTicks(8881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 146, DateTimeKind.Local).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(6082));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 741, DateTimeKind.Local).AddTicks(1097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 741, DateTimeKind.Local).AddTicks(1278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(5653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(5854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(3319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(3657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("66fe0173-a431-4f80-b25e-1c45d3509f3a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("ab2fd76a-d469-4180-b979-e4d07f5b02f3"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(2239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 739, DateTimeKind.Local).AddTicks(9949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(3339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(3464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 736, DateTimeKind.Local).AddTicks(8837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 148, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 736, DateTimeKind.Local).AddTicks(9022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 148, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorUtilizado",
                table: "CarteiraCashBackLancamentos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SaldoAnterior",
                table: "CarteiraCashBackLancamentos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpiracao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(8100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 147, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(8440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 147, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(5870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 146, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(6082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 146, DateTimeKind.Local).AddTicks(9092));
        }
    }
}
