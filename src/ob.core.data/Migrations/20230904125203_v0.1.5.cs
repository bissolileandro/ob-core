using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v015 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 906, DateTimeKind.Local).AddTicks(4919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 31, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 906, DateTimeKind.Local).AddTicks(5110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 31, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(8930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(5731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("5963f2f4-6a3b-4e5d-ab28-65338692aab6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("a42a7fda-5a73-47ae-83ae-21eacb32e6b9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(1254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(1725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 903, DateTimeKind.Local).AddTicks(4792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 28, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 903, DateTimeKind.Local).AddTicks(5068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 28, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAproximadoKitGas",
                table: "CotacaoVeiculo",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAproximadoBlindagem",
                table: "CotacaoVeiculo",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 902, DateTimeKind.Local).AddTicks(459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 27, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 902, DateTimeKind.Local).AddTicks(600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 27, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAplicacaoKitGas",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAplicacaoBlindagem",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 900, DateTimeKind.Local).AddTicks(3412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 25, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 900, DateTimeKind.Local).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 25, DateTimeKind.Local).AddTicks(5984));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 31, DateTimeKind.Local).AddTicks(5603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 906, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 31, DateTimeKind.Local).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 906, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(9604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(9833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(6851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(7092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("a42a7fda-5a73-47ae-83ae-21eacb32e6b9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("5963f2f4-6a3b-4e5d-ab28-65338692aab6"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(4609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(4860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 28, DateTimeKind.Local).AddTicks(7716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 903, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 28, DateTimeKind.Local).AddTicks(7935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 903, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAproximadoKitGas",
                table: "CotacaoVeiculo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAproximadoBlindagem",
                table: "CotacaoVeiculo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 27, DateTimeKind.Local).AddTicks(3918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 902, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 27, DateTimeKind.Local).AddTicks(4060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 902, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAplicacaoKitGas",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAplicacaoBlindagem",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 25, DateTimeKind.Local).AddTicks(5758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 900, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 25, DateTimeKind.Local).AddTicks(5984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 900, DateTimeKind.Local).AddTicks(3651));
        }
    }
}
