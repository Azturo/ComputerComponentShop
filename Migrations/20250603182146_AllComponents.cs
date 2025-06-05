using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComputerComponentShop.Migrations
{
    /// <inheritdoc />
    public partial class AllComponents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirCoolers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FanSize = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    FanSpeed = table.Column<int>(type: "int", nullable: false),
                    HeatPipes = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    SocketCompatibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxTdpWatts = table.Column<int>(type: "int", nullable: false),
                    NoiseLevel = table.Column<double>(type: "float", nullable: false),
                    HasRgb = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCoolers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chassis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TowerSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherboardSupport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterCoolerSupport = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VramMemory = table.Column<int>(type: "int", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HDDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacityGb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadSpeed = table.Column<int>(type: "int", nullable: false),
                    WriteSpeed = table.Column<int>(type: "int", nullable: false),
                    Interface = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedLifetime = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Rpm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemmoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M2Slots = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wattage = table.Column<int>(type: "int", nullable: false),
                    EfficiencyRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modularity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Formfactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacityGb = table.Column<int>(type: "int", nullable: false),
                    SpeedMhz = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterCoolers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadiatorSize = table.Column<int>(type: "int", nullable: false),
                    PumpSpeed = table.Column<int>(type: "int", nullable: false),
                    FanSize = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    SocketCompatibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxTdpWatts = table.Column<int>(type: "int", nullable: false),
                    NoiseLevel = table.Column<double>(type: "float", nullable: false),
                    HasRgb = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCoolers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AirCoolers",
                columns: new[] { "Id", "Description", "FanSize", "FanSpeed", "HasRgb", "HeatPipes", "Height", "Manufacturer", "MaxTdpWatts", "ModelNumber", "Name", "NoiseLevel", "Price", "ProductCategory", "SocketCompatibility" },
                values: new object[,]
                {
                    { 701, "Balanced dual-tower cooler with stylish design.", 120, 1850, true, 6, 160.0, "DeepCool", 260, "R-AK620-BKNNMT-G-1", "DeepCool AK620", 28.0, 799m, 8, "AM4, LGA1700, LGA1200" },
                    { 702, "High-performance cooler with dual fans at a great price.", 120, 1550, false, 6, 157.0, "Thermalright", 220, "PA120", "Thermalright Peerless Assassin 120", 25.600000000000001, 649m, 8, "AM4, LGA1700" },
                    { 703, "Efficient dual-fan cooler with low noise and height.", 120, 1200, true, 6, 154.5, "Scythe", 200, "SCFM-2000", "Scythe Fuma 2 Rev.B", 23.0, 699m, 8, "AM4, LGA1700" },
                    { 704, "Popular budget-friendly cooler with solid performance.", 120, 1800, false, 4, 159.0, "Cooler Master", 150, "RR-212S-20PK-R1", "Cooler Master Hyper 212 Black Edition", 26.0, 499m, 8, "AM4, LGA1700" },
                    { 705, "Silent dual-tower cooler with excellent heat dissipation.", 135, 1500, true, 7, 162.0, "be quiet!", 250, "BK022", "be quiet! Dark Rock Pro 4", 24.300000000000001, 899m, 8, "AM4, LGA1700" },
                    { 706, "High-end dual-tower air cooler with excellent performance.", 140, 1500, true, 6, 165.0, "Noctua", 220, "NH-D15", "Noctua NH-D15", 24.600000000000001, 999m, 8, "AM4, LGA1700, LGA1200" }
                });

            migrationBuilder.InsertData(
                table: "Chassis",
                columns: new[] { "Id", "Description", "FormFactor", "Manufacturer", "ModelNumber", "MotherboardSupport", "Name", "Price", "ProductCategory", "TowerSize", "WaterCoolerSupport" },
                values: new object[,]
                {
                    { 901, "Mid-tower with minimalist design and tempered glass side panel.", "ATX", "NZXT", "CA-H510B-B1", "ATX, Micro-ATX, Mini-ITX", "NZXT H510", 899m, 9, "Mid Tower", true },
                    { 902, "Compact mid-tower with excellent airflow and modern design.", "ATX", "Fractal Design", "FD-CA-MESH-C-BKO-TG", "ATX, Micro-ATX, Mini-ITX", "Fractal Design Meshify C", 999m, 9, "Mid Tower", true },
                    { 903, "Compact case with modular design and dust filters.", "Micro-ATX", "Cooler Master", "MCB-Q300L-KANN-S00", "Micro-ATX, Mini-ITX", "Cooler Master MasterBox Q300L", 599m, 9, "Mini Tower", false },
                    { 904, "Showcase chassis with dual-chamber design and tempered glass.", "ATX", "Lian Li", "PC-O11DW", "ATX, Micro-ATX, Mini-ITX, E-ATX", "Lian Li PC-O11 Dynamic", 1399m, 9, "Mid Tower", true },
                    { 905, "High airflow case with mesh front panel and RGB lighting.", "ATX", "Phanteks", "PH-EC400ATG_DWT01", "ATX, Micro-ATX, Mini-ITX", "Phanteks Eclipse P400A", 1099m, 9, "Mid Tower", true },
                    { 906, "Cube-style micro ATX case with versatile layout options.", "Micro-ATX", "Thermaltake", "CA-1D5-00S1WN-00", "Micro-ATX, Mini-ITX", "Thermaltake Core V21", 649m, 9, "Micro Tower", true }
                });

            migrationBuilder.InsertData(
                table: "GPUs",
                columns: new[] { "Id", "Chipset", "Description", "Manufacturer", "ModelNumber", "Name", "Price", "ProductCategory", "VramMemory" },
                values: new object[,]
                {
                    { 201, "Ada Lovelace", "High-end gaming GPU with ray tracing and DLSS 3.", "NVIDIA", "RTX4070TI-12G", "NVIDIA GeForce RTX 4070 Ti", 9290m, 4, 12 },
                    { 202, "RDNA 3", "Powerful RDNA 3 architecture with high VRAM for 4K gaming.", "AMD", "RX7900XT-20G", "AMD Radeon RX 7900 XT", 8790m, 4, 20 },
                    { 203, "Ampere", "Budget-friendly GPU with solid 1080p performance.", "NVIDIA", "RTX3060-12G", "NVIDIA GeForce RTX 3060", 3490m, 4, 12 },
                    { 204, "RDNA 2", "Strong 1440p performance with fast memory bandwidth.", "AMD", "RX6750XT-12G", "AMD Radeon RX 6750 XT", 4590m, 4, 12 },
                    { 205, "Alchemist", "Intel's high-end GPU with Xe HPG architecture.", "Intel", "ARC-A770-16G", "Intel Arc A770", 3990m, 4, 16 },
                    { 206, "Turing", "Reliable mid-range GPU for 1080p gaming.", "NVIDIA", "GTX1660S-6G", "NVIDIA GeForce GTX 1660 Super", 2290m, 4, 6 }
                });

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

            migrationBuilder.InsertData(
                table: "Motherboards",
                columns: new[] { "Id", "Chipset", "Description", "FormFactor", "M2Slots", "Manufacturer", "MemmoryType", "ModelNumber", "Name", "Price", "ProductCategory", "Socket" },
                values: new object[,]
                {
                    { 101, "B650", "Micro-ATX motherboard for AMD Ryzen with PCIe 4.0 and DDR5 support.", "Micro-ATX", 2, "MSI", "DDR5", "B650M-MORTAR-WIFI", "MSI B650M Mortar WiFi", 1990m, 0, "AM5" },
                    { 102, "Z790", "Premium Intel Z790 motherboard with high-end features for gamers.", "ATX", 4, "ASUS", "DDR5", "90MB1CW0-M0EAY0", "ASUS ROG Strix Z790-E Gaming WiFi", 4290m, 0, "LGA1700" },
                    { 103, "B550", "Affordable AM4 motherboard with strong VRM and PCIe 4.0.", "ATX", 2, "Gigabyte", "DDR4", "B550-AORUS-ELITE-V2", "Gigabyte B550 AORUS Elite V2", 1390m, 0, "AM4" },
                    { 104, "B460", "Entry-level Intel motherboard with solid features for budget builds.", "Micro-ATX", 1, "ASUS", "DDR4", "B460M-A", "ASUS PRIME B460M-A", 990m, 0, "LGA1200" },
                    { 105, "X670E", "Flagship AM5 motherboard with PCIe 5.0 and robust power delivery.", "ATX", 4, "ASRock", "DDR5", "X670E-TAICHI", "ASRock X670E Taichi", 5890m, 0, "AM5" },
                    { 106, "Z690", "Well-balanced Z690 motherboard with DDR4 support for 12th gen Intel CPUs.", "ATX", 3, "MSI", "DDR4", "Z690-A-PRO-DDR4", "MSI PRO Z690-A DDR4", 2190m, 0, "LGA1700" }
                });

            migrationBuilder.InsertData(
                table: "PowerSupplies",
                columns: new[] { "Id", "Description", "EfficiencyRating", "Formfactor", "Manufacturer", "ModelNumber", "Modularity", "Name", "Price", "ProductCategory", "Wattage" },
                values: new object[,]
                {
                    { 301, "750W 80+ Gold Certified Fully Modular", "80+ Gold", "ATX", "Corsair", "CP-9020179-EU", "Modular", "Corsair RM750x", 1299m, 1, 750 },
                    { 302, "650W 80+ Gold Fully Modular PSU", "80+ Gold", "ATX", "Seasonic", "FOCUS-GX-650", "Modular", "Seasonic Focus GX-650", 1149m, 1, 650 },
                    { 303, "850W 80+ Platinum Fully Modular", "80+ Platinum", "ATX", "be quiet!", "BN641", "Modular", "be quiet! Straight Power 11", 1799m, 1, 850 },
                    { 304, "600W 80+ Bronze Non-Modular", "80+ Bronze", "ATX", "EVGA", "100-BR-0600-K1", "Non-Modular", "EVGA 600 BR", 699m, 1, 600 },
                    { 305, "550W 80+ Bronze Semi Modular", "80+ Bronze", "ATX", "Cooler Master", "MPX-5501-ACAAB", "Semi-Modular", "Cooler Master MWE Bronze 550", 749m, 1, 550 },
                    { 306, "760W 80+ Platinum Fully Modular", "80+ Platinum", "ATX", "Fractal Design", "FD-PSU-IONP-760P-BK", "Modular", "Fractal Design Ion+ 760P", 1549m, 1, 760 }
                });

            migrationBuilder.InsertData(
                table: "Rams",
                columns: new[] { "Id", "CapacityGb", "Description", "Latency", "Manufacturer", "ModelNumber", "Name", "Price", "ProductCategory", "SpeedMhz", "Type" },
                values: new object[,]
                {
                    { 801, 32, "Gaming RAM with vibrant RGB lighting.", "CL34", "TeamGroup", "FF3D532G7200HC34ADC01", "TeamGroup T-Force Delta RGB", 1599m, 2, 7200, "DDR5" },
                    { 802, 16, "Performance RAM without the flash.", "CL18", "Patriot", "PVS416G360C8K", "Patriot Viper Steel", 1199m, 2, 3600, "DDR4" },
                    { 803, 32, "Premium RAM with powerful RGB and speed.", "CL36", "Corsair", "CMT32GX5M2B5600C36", "Corsair Dominator Platinum RGB", 1799m, 2, 5600, "DDR5" },
                    { 804, 16, "Reliable RAM for gaming builds.", "CL16", "Kingston", "KF432C16BBK2/16", "Kingston Fury Beast", 749m, 2, 3200, "DDR4" },
                    { 805, 16, "Stylish RGB RAM with high clock speeds.", "CL18", "G.Skill", "F4-3600C18D-16GTZR", "G.Skill Trident Z RGB", 1399m, 2, 3600, "DDR4" },
                    { 806, 16, "High-performance DDR4 memory for gaming and multitasking.", "CL16", "Corsair", "CMK16GX4M2B3200C16", "Corsair Vengeance LPX", 899m, 2, 3200, "DDR4" }
                });

            migrationBuilder.InsertData(
                table: "WaterCoolers",
                columns: new[] { "Id", "Description", "FanSize", "HasRgb", "Manufacturer", "MaxTdpWatts", "ModelNumber", "Name", "NoiseLevel", "Price", "ProductCategory", "PumpSpeed", "RadiatorSize", "SocketCompatibility" },
                values: new object[,]
                {
                    { 601, "Premium 360mm AIO with high RPM pump and vivid RGB.", 120, true, "EKWB", 350, "3831109863489", "EK-AIO Elite 360 D-RGB", 29.0, 2699m, 7, 3100, 360, "AM4, LGA1700, LGA1200" },
                    { 602, "Powerful cooling with integrated VRM fan.", 140, false, "Arctic", 250, "ACFRE00063A", "Arctic Liquid Freezer II 280", 22.5, 1299m, 7, 2000, 280, "AM4, LGA1700" },
                    { 603, "Budget-friendly 240mm AIO cooler with RGB fans.", 120, true, "Cooler Master", 200, "MLW-D24M-A18PC-R2", "Cooler Master MasterLiquid ML240L V2", 27.0, 999m, 7, 2600, 240, "AM4, LGA1700, LGA1200" },
                    { 604, "Ultra-quiet 360mm AIO water cooler for powerful CPUs.", 120, false, "be quiet!", 300, "BW011", "be quiet! Silent Loop 2", 20.399999999999999, 2299m, 7, 2800, 360, "AM4, LGA1700, TR4" },
                    { 605, "AIO 280mm CPU cooler with RGB and quiet operation.", 140, true, "NZXT", 280, "RL-KRX63-01", "NZXT Kraken X63", 21.5, 1899m, 7, 3000, 280, "AM4, LGA1200, LGA1700" },
                    { 606, "High-performance 240mm liquid CPU cooler with RGB fans.", 120, true, "Corsair", 250, "CW-9060039-WW", "Corsair H100i RGB Platinum", 25.0, 1599m, 7, 2700, 240, "AM4, LGA1200, LGA1700" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirCoolers");

            migrationBuilder.DropTable(
                name: "Chassis");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "HDDs");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "Rams");

            migrationBuilder.DropTable(
                name: "WaterCoolers");
        }
    }
}
