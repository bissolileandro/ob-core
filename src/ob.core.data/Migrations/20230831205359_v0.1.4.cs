using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v014 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPFOUCNPJ",
                table: "CotacaoVeiculo");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "CotacaoVeiculo");

            migrationBuilder.DropColumn(
                name: "DataAplicacaoBlindagem",
                table: "CotacaoDetalhes");

            migrationBuilder.DropColumn(
                name: "PossuiBlindagem",
                table: "CotacaoDetalhes");

            migrationBuilder.DropColumn(
                name: "ValorAproximadoBlindagem",
                table: "CotacaoDetalhes");

            migrationBuilder.DropColumn(
                name: "ValorAproximadoKitGas",
                table: "CotacaoDetalhes");

            migrationBuilder.RenameColumn(
                name: "PrincipalMotoristaVeiculo",
                table: "CotacaoVeiculo",
                newName: "PossuiKitGas");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "CotacaoVeiculo",
                newName: "CepVeiculoPerNoite");

            migrationBuilder.RenameColumn(
                name: "VeiculoPerNoite",
                table: "CotacaoDetalhes",
                newName: "NomeMotorista");

            migrationBuilder.RenameColumn(
                name: "PossuiKitGas",
                table: "CotacaoDetalhes",
                newName: "PrincipalMotoristaVeiculo");

            migrationBuilder.RenameColumn(
                name: "DataAplicacaoKitGas",
                table: "CotacaoDetalhes",
                newName: "DataNascimento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 31, DateTimeKind.Local).AddTicks(5603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 882, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 31, DateTimeKind.Local).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 882, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(9604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(9833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(6851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(7092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("a42a7fda-5a73-47ae-83ae-21eacb32e6b9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3aa9eff0-a245-4f04-8a9b-4bb2e04519ea"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(4609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(4860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 28, DateTimeKind.Local).AddTicks(7716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 879, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 28, DateTimeKind.Local).AddTicks(7935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 879, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 27, DateTimeKind.Local).AddTicks(3918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 878, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 27, DateTimeKind.Local).AddTicks(4060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 878, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAplicacaoBlindagem",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAplicacaoKitGas",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "PossuiBlindagem",
                table: "CotacaoVeiculo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorAproximadoBlindagem",
                table: "CotacaoVeiculo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorAproximadoKitGas",
                table: "CotacaoVeiculo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CpfOuCnpj",
                table: "CotacaoDetalhes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivil",
                table: "CotacaoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 25, DateTimeKind.Local).AddTicks(5758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 876, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 25, DateTimeKind.Local).AddTicks(5984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 876, DateTimeKind.Local).AddTicks(8143));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAplicacaoBlindagem",
                table: "CotacaoVeiculo");

            migrationBuilder.DropColumn(
                name: "DataAplicacaoKitGas",
                table: "CotacaoVeiculo");

            migrationBuilder.DropColumn(
                name: "PossuiBlindagem",
                table: "CotacaoVeiculo");

            migrationBuilder.DropColumn(
                name: "ValorAproximadoBlindagem",
                table: "CotacaoVeiculo");

            migrationBuilder.DropColumn(
                name: "ValorAproximadoKitGas",
                table: "CotacaoVeiculo");

            migrationBuilder.DropColumn(
                name: "CpfOuCnpj",
                table: "CotacaoDetalhes");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "CotacaoDetalhes");

            migrationBuilder.RenameColumn(
                name: "PossuiKitGas",
                table: "CotacaoVeiculo",
                newName: "PrincipalMotoristaVeiculo");

            migrationBuilder.RenameColumn(
                name: "CepVeiculoPerNoite",
                table: "CotacaoVeiculo",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "PrincipalMotoristaVeiculo",
                table: "CotacaoDetalhes",
                newName: "PossuiKitGas");

            migrationBuilder.RenameColumn(
                name: "NomeMotorista",
                table: "CotacaoDetalhes",
                newName: "VeiculoPerNoite");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "CotacaoDetalhes",
                newName: "DataAplicacaoKitGas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 882, DateTimeKind.Local).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 31, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 882, DateTimeKind.Local).AddTicks(3120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 31, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(7593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(7856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(5223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(5423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3aa9eff0-a245-4f04-8a9b-4bb2e04519ea"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("a42a7fda-5a73-47ae-83ae-21eacb32e6b9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(3529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(3721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 30, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 879, DateTimeKind.Local).AddTicks(8527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 28, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 879, DateTimeKind.Local).AddTicks(8771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 28, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 878, DateTimeKind.Local).AddTicks(5481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 27, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 878, DateTimeKind.Local).AddTicks(5630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 27, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.AddColumn<string>(
                name: "CPFOUCNPJ",
                table: "CotacaoVeiculo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivil",
                table: "CotacaoVeiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAplicacaoBlindagem",
                table: "CotacaoDetalhes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "PossuiBlindagem",
                table: "CotacaoDetalhes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorAproximadoBlindagem",
                table: "CotacaoDetalhes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorAproximadoKitGas",
                table: "CotacaoDetalhes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 876, DateTimeKind.Local).AddTicks(7937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 25, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 876, DateTimeKind.Local).AddTicks(8143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 17, 53, 59, 25, DateTimeKind.Local).AddTicks(5984));
        }
    }
}
