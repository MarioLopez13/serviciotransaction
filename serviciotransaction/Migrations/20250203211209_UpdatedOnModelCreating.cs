using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace serviciotransaction.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedOnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Transaccion",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Id_OrigenCli",
                table: "Transaccion",
                type: "decimal(10,0)",
                precision: 10,
                scale: 0,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Id_Cliente",
                table: "Transaccion",
                type: "decimal(10,0)",
                precision: 10,
                scale: 0,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Transaccion",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Id_OrigenCli",
                table: "Transaccion",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,0)",
                oldPrecision: 10,
                oldScale: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Id_Cliente",
                table: "Transaccion",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,0)",
                oldPrecision: 10,
                oldScale: 0);
        }
    }
}
