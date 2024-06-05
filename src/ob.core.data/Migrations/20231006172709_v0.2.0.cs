using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v020 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 485, DateTimeKind.Local).AddTicks(196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioGuardaChuva",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioGuardaChuva",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(2718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(3005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e85f51d5-950a-4de0-b013-480c2a8ab59b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("ab2fd76a-d469-4180-b979-e4d07f5b02f3"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(2856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(3047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(7977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(8190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 148, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 148, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 147, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 147, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 146, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 146, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.CreateTable(
                name: "FaqSistema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SistemaId = table.Column<int>(type: "int", nullable: false),
                    Pergunta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(3070)),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(3282))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaqSistema", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaqSistema_Sistema_SistemaId",
                        column: x => x.SistemaId,
                        principalTable: "Sistema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FaqSistema_SistemaId",
                table: "FaqSistema",
                column: "SistemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaqSistema");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(7386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(7565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 485, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioGuardaChuva",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(9534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioGuardaChuva",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 14, 19, 43, 282, DateTimeKind.Local).AddTicks(9838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(2160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(2365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 152, DateTimeKind.Local).AddTicks(352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 484, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("ab2fd76a-d469-4180-b979-e4d07f5b02f3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e85f51d5-950a-4de0-b013-480c2a8ab59b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(8932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(9144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(7123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 151, DateTimeKind.Local).AddTicks(7317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 483, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(6335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "EmailConfiguracao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(6532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 481, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(1068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 150, DateTimeKind.Local).AddTicks(1207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 480, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 148, DateTimeKind.Local).AddTicks(8276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 148, DateTimeKind.Local).AddTicks(8460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 479, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 147, DateTimeKind.Local).AddTicks(989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashBackLancamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 147, DateTimeKind.Local).AddTicks(1293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 146, DateTimeKind.Local).AddTicks(8881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CarteiraCashback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 12, 48, 40, 146, DateTimeKind.Local).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 27, 8, 477, DateTimeKind.Local).AddTicks(701));
        }
    }
}
