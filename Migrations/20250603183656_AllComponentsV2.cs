using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComputerComponentShop.Migrations
{
    /// <inheritdoc />
    public partial class AllComponentsV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "HDDs");

            migrationBuilder.DropColumn(
                name: "FormFactor",
                table: "HDDs");

            migrationBuilder.AlterColumn<string>(
                name: "Rpm",
                table: "HDDs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SSDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    CapacityGb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadSpeed = table.Column<int>(type: "int", nullable: false),
                    WriteSpeed = table.Column<int>(type: "int", nullable: false),
                    Interface = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedLifetime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSDs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SSDs",
                columns: new[] { "Id", "CapacityGb", "Description", "ExpectedLifetime", "FormFactor", "Interface", "Manufacturer", "ModelNumber", "Name", "Price", "ProductCategory", "ReadSpeed", "WriteSpeed" },
                values: new object[,]
                {
                    { 401, "1000", "NVMe M.2 SSD with high-performance Gen4 speed", 1500000, "M.2", "NVMe", "Samsung", "MZ-V8P1T0BW", "Samsung 980 PRO", 1599m, 6, 7000, 5000 },
                    { 402, "1000", "Reliable 2.5'' SATA SSD with integrated power loss immunity", 1800000, "2.5", "SATA", "Crucial", "CT1000MX500SSD1", "Crucial MX500", 899m, 6, 560, 510 },
                    { 403, "1000", "High-end PCIe Gen4 NVMe SSD for gaming", 1600000, "M.2", "NVMe", "Western Digital", "WDS100T2X0E", "WD Black SN850X", 1399m, 6, 7300, 6300 },
                    { 404, "480", "Budget-friendly SATA SSD", 1000000, "2.5", "SATA", "Kingston", "SA400S37/480G", "Kingston A400", 499m, 6, 500, 450 },
                    { 405, "1000", "QLC NVMe SSD for everyday computing", 1000000, "M.2", "NVMe", "Intel", "SSDPEKNU010TZX1", "Intel 670p", 849m, 6, 3500, 2700 },
                    { 406, "1000", "M.2 NVMe SSD with PCIe Gen4 support", 1400000, "M.2", "NVMe", "Sabrent", "SB-RKTQ4-1TB", "Sabrent Rocket Q4", 1299m, 6, 4700, 1800 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SSDs");

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "HDDs",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.AlterColumn<string>(
                name: "Rpm",
                table: "HDDs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "HDDs",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormFactor",
                table: "HDDs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "HDDs",
                columns: new[] { "Id", "CapacityGb", "Description", "Discriminator", "ExpectedLifetime", "FormFactor", "Interface", "Manufacturer", "ModelNumber", "Name", "Price", "ProductCategory", "ReadSpeed", "WriteSpeed" },
                values: new object[,]
                {
                    { 401, "1000", "NVMe M.2 SSD with high-performance Gen4 speed", "SolidStateDrive", 1500000, "M.2", "NVMe", "Samsung", "MZ-V8P1T0BW", "Samsung 980 PRO", 1599m, 6, 7000, 5000 },
                    { 402, "1000", "Reliable 2.5'' SATA SSD with integrated power loss immunity", "SolidStateDrive", 1800000, "2.5", "SATA", "Crucial", "CT1000MX500SSD1", "Crucial MX500", 899m, 6, 560, 510 },
                    { 403, "1000", "High-end PCIe Gen4 NVMe SSD for gaming", "SolidStateDrive", 1600000, "M.2", "NVMe", "Western Digital", "WDS100T2X0E", "WD Black SN850X", 1399m, 6, 7300, 6300 },
                    { 404, "480", "Budget-friendly SATA SSD", "SolidStateDrive", 1000000, "2.5", "SATA", "Kingston", "SA400S37/480G", "Kingston A400", 499m, 6, 500, 450 },
                    { 405, "1000", "QLC NVMe SSD for everyday computing", "SolidStateDrive", 1000000, "M.2", "NVMe", "Intel", "SSDPEKNU010TZX1", "Intel 670p", 849m, 6, 3500, 2700 },
                    { 406, "1000", "M.2 NVMe SSD with PCIe Gen4 support", "SolidStateDrive", 1400000, "M.2", "NVMe", "Sabrent", "SB-RKTQ4-1TB", "Sabrent Rocket Q4", 1299m, 6, 4700, 1800 }
                });

            migrationBuilder.InsertData(
                table: "HDDs",
                columns: new[] { "Id", "CapacityGb", "Description", "Discriminator", "ExpectedLifetime", "Interface", "Manufacturer", "ModelNumber", "Name", "Price", "ProductCategory", "ReadSpeed", "Rpm", "WriteSpeed" },
                values: new object[,]
                {
                    { 501, "2000", "Reliable desktop hard drive with large storage capacity", "Hdd", 1000000, "SATA", "Seagate", "ST2000DM008", "Seagate Barracuda", 749m, 10, 160, "7200", 150 },
                    { 502, "1000", "Standard desktop HDD ideal for everyday computing", "Hdd", 800000, "SATA", "Western Digital", "WD10EZEX", "WD Blue", 699m, 10, 150, "7200", 140 },
                    { 503, "2000", "Performance HDD for desktop systems", "Hdd", 1000000, "SATA", "Toshiba", "HDWD120UZSVA", "Toshiba P300", 829m, 10, 160, "7200", 150 },
                    { 504, "4000", "NAS-optimized HDD with high durability", "Hdd", 1800000, "SATA", "Seagate", "ST4000VN008", "Seagate IronWolf", 1299m, 10, 180, "5900", 170 },
                    { 505, "2000", "High-performance HDD for gaming and media workstations", "Hdd", 1200000, "SATA", "Western Digital", "WD2003FZEX", "WD Black Performance", 999m, 10, 180, "7200", 160 },
                    { 506, "10000", "Enterprise-grade hard disk drive for long-term storage", "Hdd", 2500000, "SATA", "HGST", "HUH721010ALE600", "HGST Ultrastar", 1399m, 10, 210, "7200", 200 }
                });
        }
    }
}
