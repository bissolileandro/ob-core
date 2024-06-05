using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v012 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "UsuarioLead");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 762, DateTimeKind.Local).AddTicks(382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 910, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 762, DateTimeKind.Local).AddTicks(716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 910, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(5037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(5266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(2722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(2987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("92dd0267-6cf6-4b76-87e0-85924cd40278"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("76ddea9e-04c4-46a2-8ba5-8ea4f24835b0"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(1135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 759, DateTimeKind.Local).AddTicks(5700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 907, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 759, DateTimeKind.Local).AddTicks(5923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 907, DateTimeKind.Local).AddTicks(6998));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 910, DateTimeKind.Local).AddTicks(2985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 762, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 910, DateTimeKind.Local).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 762, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "UsuarioLead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(7072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(7346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(4504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(4689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("76ddea9e-04c4-46a2-8ba5-8ea4f24835b0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("92dd0267-6cf6-4b76-87e0-85924cd40278"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(2734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 909, DateTimeKind.Local).AddTicks(2953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 761, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 907, DateTimeKind.Local).AddTicks(6705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 759, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 13, 21, 30, 907, DateTimeKind.Local).AddTicks(6998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 6, 759, DateTimeKind.Local).AddTicks(5923));
        }
    }
}
