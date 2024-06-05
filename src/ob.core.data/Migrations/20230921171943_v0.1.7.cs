using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v017 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 283, DateTimeKind.Local).AddTicks(4964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 283, DateTimeKind.Local).AddTicks(5117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(7970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(8206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.AddColumn<Guid>(
                name: "CodigoIndicacao",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "LimiteIndicacao",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(5175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(5529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("25f3a23d-7c91-46cb-b176-bd24ea04a081"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("b154d3d8-db7f-4574-9bf8-fb603b33dc61"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(3684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(3845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 279, DateTimeKind.Local).AddTicks(9459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 279, DateTimeKind.Local).AddTicks(9680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 278, DateTimeKind.Local).AddTicks(6835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 278, DateTimeKind.Local).AddTicks(7029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 278, DateTimeKind.Local).AddTicks(1841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 278, DateTimeKind.Local).AddTicks(1989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 276, DateTimeKind.Local).AddTicks(6682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 276, DateTimeKind.Local).AddTicks(6894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.CreateTable(
                name: "UsuarioGuardaChuva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioIndicacaoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioIndicadoId = table.Column<int>(type: "int", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    NivelIndicacao = table.Column<int>(type: "int", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(9534)),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(9838))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioGuardaChuva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioGuardaChuva_Usuario_UsuarioIndicacaoId",
                        column: x => x.UsuarioIndicacaoId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioGuardaChuva_UsuarioIndicacaoId",
                table: "UsuarioGuardaChuva",
                column: "UsuarioIndicacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioGuardaChuva");

            migrationBuilder.DropColumn(
                name: "CodigoIndicacao",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "LimiteIndicacao",
                table: "Usuario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(7957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 283, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(8119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 283, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("b154d3d8-db7f-4574-9bf8-fb603b33dc61"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("25f3a23d-7c91-46cb-b176-bd24ea04a081"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(1890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 279, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(2148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 279, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 278, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 278, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 278, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 278, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 276, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 276, DateTimeKind.Local).AddTicks(6894));
        }
    }
}
