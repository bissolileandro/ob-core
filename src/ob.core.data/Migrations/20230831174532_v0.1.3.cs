using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v013 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 882, DateTimeKind.Local).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 762, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 882, DateTimeKind.Local).AddTicks(3120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 762, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(7593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(7856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(5223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(5423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3aa9eff0-a245-4f04-8a9b-4bb2e04519ea"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("92dd0267-6cf6-4b76-87e0-85924cd40278"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(3529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(3721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 879, DateTimeKind.Local).AddTicks(8527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 759, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 879, DateTimeKind.Local).AddTicks(8771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 759, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.CreateTable(
                name: "Cotacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 876, DateTimeKind.Local).AddTicks(7937)),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 876, DateTimeKind.Local).AddTicks(8143))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CotacaoDetalhes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CotacaoId = table.Column<int>(type: "int", nullable: false),
                    VeiculoPerNoite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotoristaEntre18E15Anos = table.Column<bool>(type: "bit", nullable: false),
                    PossuiBlindagem = table.Column<bool>(type: "bit", nullable: false),
                    DataAplicacaoBlindagem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorAproximadoBlindagem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PossuiKitGas = table.Column<bool>(type: "bit", nullable: false),
                    DataAplicacaoKitGas = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorAproximadoKitGas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotacaoDetalhes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CotacaoDetalhes_Cotacao_CotacaoId",
                        column: x => x.CotacaoId,
                        principalTable: "Cotacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CotacaoVeiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CotacaoId = table.Column<int>(type: "int", nullable: false),
                    PrincipalMotoristaVeiculo = table.Column<bool>(type: "bit", nullable: false),
                    DataNascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPFOUCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoCivil = table.Column<int>(type: "int", nullable: false),
                    VeiculoZeroKm = table.Column<bool>(type: "bit", nullable: false),
                    NumeroPlaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoModelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarcaVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeloVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 878, DateTimeKind.Local).AddTicks(5481)),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 878, DateTimeKind.Local).AddTicks(5630))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotacaoVeiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CotacaoVeiculo_Cotacao_CotacaoId",
                        column: x => x.CotacaoId,
                        principalTable: "Cotacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CotacaoDetalhes_CotacaoId",
                table: "CotacaoDetalhes",
                column: "CotacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CotacaoVeiculo_CotacaoId",
                table: "CotacaoVeiculo",
                column: "CotacaoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CotacaoDetalhes");

            migrationBuilder.DropTable(
                name: "CotacaoVeiculo");

            migrationBuilder.DropTable(
                name: "Cotacao");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 762, DateTimeKind.Local).AddTicks(382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 882, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 762, DateTimeKind.Local).AddTicks(716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 882, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(5037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(5266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(2722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(2987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("92dd0267-6cf6-4b76-87e0-85924cd40278"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3aa9eff0-a245-4f04-8a9b-4bb2e04519ea"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(1135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 881, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 759, DateTimeKind.Local).AddTicks(5700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 879, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 759, DateTimeKind.Local).AddTicks(5923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 45, 32, 879, DateTimeKind.Local).AddTicks(8771));
        }
    }
}
