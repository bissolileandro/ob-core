using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ob.core.data.Migrations
{
    /// <inheritdoc />
    public partial class v016 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(7957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 906, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(8119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 906, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("b154d3d8-db7f-4574-9bf8-fb603b33dc61"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("5963f2f4-6a3b-4e5d-ab28-65338692aab6"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(1890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 903, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(2148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 903, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 902, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 902, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 900, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 900, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.CreateTable(
                name: "EmailConfiguracao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmtpServidor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmptPorta = table.Column<int>(type: "int", nullable: false),
                    SmptEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmptSenha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8743)),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(8951))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfiguracao", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailConfiguracao");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 906, DateTimeKind.Local).AddTicks(4919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "UsuarioLead",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 906, DateTimeKind.Local).AddTicks(5110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(8930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 156, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(5731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Sistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChaveDeAcesso",
                table: "Sistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("5963f2f4-6a3b-4e5d-ab28-65338692aab6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("b154d3d8-db7f-4574-9bf8-fb603b33dc61"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(1254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "PerfilUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 905, DateTimeKind.Local).AddTicks(1725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 155, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 903, DateTimeKind.Local).AddTicks(4792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "ParametrosDeSistema",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 903, DateTimeKind.Local).AddTicks(5068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 154, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 902, DateTimeKind.Local).AddTicks(459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "CotacaoVeiculo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 902, DateTimeKind.Local).AddTicks(600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 152, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 900, DateTimeKind.Local).AddTicks(3412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Cotacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 9, 52, 3, 900, DateTimeKind.Local).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 10, 12, 7, 150, DateTimeKind.Local).AddTicks(7362));
        }
    }
}
