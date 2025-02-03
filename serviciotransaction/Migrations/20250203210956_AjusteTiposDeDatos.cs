using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace serviciotransaction.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTiposDeDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaccion");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Transaccion",
                newName: "Fecha_Transaccion");

            migrationBuilder.AddColumn<decimal>(
                name: "Id_Cliente",
                table: "Transaccion",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Id_OrigenCli",
                table: "Transaccion",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaccion",
                table: "Transaccion",
                column: "Id_Transaccion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaccion",
                table: "Transaccion");

            migrationBuilder.DropColumn(
                name: "Id_Cliente",
                table: "Transaccion");

            migrationBuilder.DropColumn(
                name: "Id_OrigenCli",
                table: "Transaccion");

            migrationBuilder.RenameTable(
                name: "Transaccion",
                newName: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Fecha_Transaccion",
                table: "Transactions",
                newName: "Fecha");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id_Transaccion");
        }
    }
}
