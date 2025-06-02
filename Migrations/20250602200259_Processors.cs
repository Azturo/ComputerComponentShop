using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComputerComponentShop.Migrations
{
    /// <inheritdoc />
    public partial class Processors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.InsertData(
                table: "Processors",
                columns: new[] { "Id", "BaseClockSpeed", "BoostClockSpeed", "CpuCores", "Description", "Manufacturer", "ModelNumber", "Name", "Price", "ProductCategory", "Socket", "Threads" },
                values: new object[,]
                {
                    { 1, 4.7000000000000002, 5.2999999999999998, 6, "6-core processor with high single-thread performance.", "AMD", "100-100000593WOF", "AMD Ryzen 5 7600X", 2790m, 3, "AM5", 12 },
                    { 2, 3.5, 5.0999999999999996, 14, "Hybrid architecture with performance and efficiency cores.", "Intel", "BX8071513600K", "Intel Core i5-13600K", 3290m, 3, "LGA1700", 20 },
                    { 3, 3.3999999999999999, 5.5999999999999996, 20, "Great balance for gaming and productivity workloads.", "Intel", "BX8071514700K", "Intel Core i7-14700K", 4490m, 3, "LGA1700", 28 },
                    { 4, 3.7999999999999998, 4.7000000000000002, 8, "High-performance AM4 processor with 8 cores.", "AMD", "100-100000063WOF", "AMD Ryzen 7 5800X", 2690m, 3, "AM4", 16 },
                    { 5, 3.7000000000000002, 4.7999999999999998, 12, "Powerful 12-core AM4 processor for gaming and productivity.", "AMD", "100-100000061WOF", "AMD Ryzen 9 5900X", 4490m, 3, "AM4", 24 },
                    { 6, 3.2000000000000002, 6.0, 24, "Flagship processor with maximum performance for enthusiasts.", "Intel", "BX8071514900K", "Intel Core i9-14900K", 6990m, 3, "LGA1700", 32 },
                    { 7, 2.8999999999999999, 4.2999999999999998, 6, "6-core budget-friendly CPU, great for entry-level gaming.", "Intel", "BX8070110400F", "Intel Core i5-10400F", 1390m, 3, "LGA1200", 12 },
                    { 8, 3.8999999999999999, 4.9000000000000004, 6, "6-core 11th gen CPU with strong single-core performance.", "Intel", "BX8070811600K", "Intel Core i5-11600K", 2190m, 3, "LGA1200", 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.InsertData(
                table: "Processors",
                columns: new[] { "Id", "BaseClockSpeed", "BoostClockSpeed", "CpuCores", "Description", "Manufacturer", "ModelNumber", "Name", "Price", "ProductCategory", "Socket", "Threads" },
                values: new object[] { -99, 4.7000000000000002, 5.2999999999999998, 6, "6-core processor with high single-thread performance.", "AMD", "100-100000593WOF", "AMD Ryzen 5 7600X", 2790m, 3, "AM5", 12 });
        }
    }
}
