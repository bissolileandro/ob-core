using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v009 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 628, DateTimeKind.Local).AddTicks(3189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 296, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 628, DateTimeKind.Local).AddTicks(3387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 296, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(7172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 295, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(7471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 295, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(3684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 295, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(3982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 295, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("c3a4ca7c-0624-48c2-be65-ef7da9a4ce22"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("76ac7223-83c5-4cef-b57e-27b266803d95"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(1883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 293, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 293, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 625, DateTimeKind.Local).AddTicks(7062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 625, DateTimeKind.Local).AddTicks(7351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 296, DateTimeKind.Local).AddTicks(3895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 628, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 296, DateTimeKind.Local).AddTicks(4068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 628, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 295, DateTimeKind.Local).AddTicks(7774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 295, DateTimeKind.Local).AddTicks(8016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 295, DateTimeKind.Local).AddTicks(4562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 295, DateTimeKind.Local).AddTicks(4817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("76ac7223-83c5-4cef-b57e-27b266803d95"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("c3a4ca7c-0624-48c2-be65-ef7da9a4ce22"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 293, DateTimeKind.Local).AddTicks(6755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 17, 29, 53, 293, DateTimeKind.Local).AddTicks(6975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 627, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 625, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 17, 37, 7, 625, DateTimeKind.Local).AddTicks(7351));
        }
    }
}
