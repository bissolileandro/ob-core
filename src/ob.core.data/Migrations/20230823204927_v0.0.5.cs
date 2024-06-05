using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v005 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 31, DateTimeKind.Local).AddTicks(9533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 866, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 32, DateTimeKind.Local).AddTicks(363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 866, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 30, DateTimeKind.Local).AddTicks(8416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 865, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 30, DateTimeKind.Local).AddTicks(9308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 865, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 29, DateTimeKind.Local).AddTicks(4586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 864, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 29, DateTimeKind.Local).AddTicks(4872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 864, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.CreateTable(
                name: "Sistema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<int>(type: "int", nullable: false),
                    ChaveDeAcesso = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValue: new Guid("57a06072-e0d8-421a-83fc-8cfa52109751")),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 30, DateTimeKind.Local).AddTicks(4337)),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 30, DateTimeKind.Local).AddTicks(5001))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistema", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sistema");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 866, DateTimeKind.Local).AddTicks(6739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 31, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 866, DateTimeKind.Local).AddTicks(7223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 32, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 865, DateTimeKind.Local).AddTicks(901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 30, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 865, DateTimeKind.Local).AddTicks(1560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 30, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 864, DateTimeKind.Local).AddTicks(4297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 29, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 17, 21, 29, 864, DateTimeKind.Local).AddTicks(5126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 49, 27, 29, DateTimeKind.Local).AddTicks(4872));
        }
    }
}
