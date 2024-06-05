using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v018 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 741, DateTimeKind.Local).AddTicks(1097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 741, DateTimeKind.Local).AddTicks(1278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(5653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(5854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(3319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(3657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("66fe0173-a431-4f80-b25e-1c45d3509f3a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("b154d3d8-db7f-4574-9bf8-fb603b33dc61"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(2239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 739, DateTimeKind.Local).AddTicks(9949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(3339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(3464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 736, DateTimeKind.Local).AddTicks(8837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 736, DateTimeKind.Local).AddTicks(9022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.CreateTable(
                name: "CarteiraCashback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaldoAtual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(5870)),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(6082))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarteiraCashback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarteiraCashback_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarteiraCashBackLancamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorUtilizado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoLancamento = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaldoAnterior = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataExpiracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarteiraCashbackId = table.Column<int>(type: "int", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(8100)),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 734, DateTimeKind.Local).AddTicks(8440))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarteiraCashBackLancamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarteiraCashBackLancamentos_CarteiraCashback_CarteiraCashbackId",
                        column: x => x.CarteiraCashbackId,
                        principalTable: "CarteiraCashback",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarteiraCashback_UsuarioId",
                table: "CarteiraCashback",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarteiraCashBackLancamentos_CarteiraCashbackId",
                table: "CarteiraCashBackLancamentos",
                column: "CarteiraCashbackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarteiraCashBackLancamentos");

            migrationBuilder.DropTable(
                name: "CarteiraCashback");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(7957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 741, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(8119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 741, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("b154d3d8-db7f-4574-9bf8-fb603b33dc61"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("66fe0173-a431-4f80-b25e-1c45d3509f3a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(1890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 739, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(2148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 740, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 738, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 736, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 11, 32, 27, 736, DateTimeKind.Local).AddTicks(9022));
        }
    }
}
