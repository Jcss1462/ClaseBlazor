using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class addProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "9c21472d-7d3b-4dad-a6e1-1517f50884d4");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d52fa413-87f4-413f-972f-b6a7ff299ea1");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "TotalQuantity" },
                values: new object[,]
                {
                    { "ASJ-98745", "PRF", "", "Crema para manos marca Tersa", 0 },
                    { "RPT-54658", "SLD", "", "Pastillas para la garganta LESUS", 0 }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "044031b0-e48f-425d-92f4-abd6f8311ae1", "Calle norte con occidente", "Bodega Norte" },
                    { "48df5aca-ba4d-4234-8be3-90252c268d1a", "Calle 8 con 23", "Bodega Central" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "ASJ-98745");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "RPT-54658");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "044031b0-e48f-425d-92f4-abd6f8311ae1");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "48df5aca-ba4d-4234-8be3-90252c268d1a");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "9c21472d-7d3b-4dad-a6e1-1517f50884d4", "Calle norte con occidente", "Bodega Norte" },
                    { "d52fa413-87f4-413f-972f-b6a7ff299ea1", "Calle 8 con 23", "Bodega Central" }
                });
        }
    }
}
