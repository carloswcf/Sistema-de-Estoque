using Microsoft.EntityFrameworkCore.Migrations;

namespace EstoqueComBD.Migrations
{
    public partial class Populando_TabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "cliente",
                columns: new[] { "id_cliente", "email", "nome" },
                values: new object[] { 1, "pedro@gmail.com", "Pedro Silva" });

            migrationBuilder.InsertData(
                table: "cliente",
                columns: new[] { "id_cliente", "email", "nome" },
                values: new object[] { 2, "maria@gmail.com", "Maria Souza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cliente",
                keyColumn: "id_cliente",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "cliente",
                keyColumn: "id_cliente",
                keyValue: 2);
        }
    }
}
