using System.Runtime.CompilerServices;
using ComputerComponentShop.Models.BaseClasses;
using ComputerComponentShop.Models.ProductClasses;
using ComputerComponentShop.Models.ProductEnums;
using Microsoft.EntityFrameworkCore;

namespace ComputerComponentShop.Models.DataBase
{
    public class ComputerComponentContext : DbContext
    {
        //public DbSet<Product> Products { get; set; }
        public DbSet<Processor> Processors { get; set; }

        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<GraphicCard> GPUs { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<SolidStateDrive> SSDs { get; set; }
        public DbSet<Hdd> HDDs { get; set; }
        public DbSet<WaterCooler> WaterCoolers { get; set; }
        public DbSet<AirCooler> AirCoolers { get; set; }
        public DbSet<Chassi> Chassis { get; set; }
        public DbSet<Ram> Rams { get; set; }


        public ComputerComponentContext(DbContextOptions<ComputerComponentContext> aOptions) : base(aOptions) 
        {
        
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Add Processors
            modelBuilder.Entity<Processor>().HasData(
                new Processor
                {
                    Id = 1,
                    Name = "AMD Ryzen 5 7600X",
                    Description = "6-core processor with high single-thread performance.",
                    Price = 2790m,
                    Manufacturer = "AMD",
                    ModelNumber = "100-100000593WOF",
                    ProductCategory = ProductCategory.CPU,
                    CpuCores = 6,
                    Threads = 12,
                    BaseClockSpeed = 4.7,
                    BoostClockSpeed = 5.3,
                    Socket = "AM5"
                },
                new Processor
                {
                    Id= 2,
                    Name = "Intel Core i5-13600K",
                    Description = "Hybrid architecture with performance and efficiency cores.",
                    Price = 3290m,
                    Manufacturer = "Intel",
                    ModelNumber = "BX8071513600K",
                    ProductCategory = ProductCategory.CPU,
                    CpuCores = 14,
                    Threads = 20,
                    BaseClockSpeed = 3.5,
                    BoostClockSpeed = 5.1,
                    Socket = "LGA1700"
                },
                new Processor
                {
                    Id = 3,
                    Name = "Intel Core i7-14700K",
                    Description = "Great balance for gaming and productivity workloads.",
                    Price = 4490m,
                    Manufacturer = "Intel",
                    ModelNumber = "BX8071514700K",
                    ProductCategory = ProductCategory.CPU,
                    CpuCores = 20,
                    Threads = 28,
                    BaseClockSpeed = 3.4,
                    BoostClockSpeed = 5.6,
                    Socket = "LGA1700"
                },
                new Processor
                {
                    Id = 4,
                    Name = "AMD Ryzen 7 5800X",
                    Description = "High-performance AM4 processor with 8 cores.",
                    Price = 2690m,
                    Manufacturer = "AMD",
                    ModelNumber = "100-100000063WOF",
                    ProductCategory = ProductCategory.CPU,
                    CpuCores = 8,
                    Threads = 16,
                    BaseClockSpeed = 3.8,
                    BoostClockSpeed = 4.7,
                    Socket = "AM4"
                },
                new Processor
                {
                    Id = 5,
                    Name = "AMD Ryzen 9 5900X",
                    Description = "Powerful 12-core AM4 processor for gaming and productivity.",
                    Price = 4490m,
                    Manufacturer = "AMD",
                    ModelNumber = "100-100000061WOF",
                    ProductCategory = ProductCategory.CPU,
                    CpuCores = 12,
                    Threads = 24,
                    BaseClockSpeed = 3.7,
                    BoostClockSpeed = 4.8,
                    Socket = "AM4"
                },
                new Processor
                {
                    Id = 6,
                    Name = "Intel Core i9-14900K",
                    Description = "Flagship processor with maximum performance for enthusiasts.",
                    Price = 6990m,
                    Manufacturer = "Intel",
                    ModelNumber = "BX8071514900K",
                    ProductCategory = ProductCategory.CPU,
                    CpuCores = 24,
                    Threads = 32,
                    BaseClockSpeed = 3.2,
                    BoostClockSpeed = 6.0,
                    Socket = "LGA1700"
                },
                new Processor
                {
                    Id = 7,
                    Name = "Intel Core i5-10400F",
                    Description = "6-core budget-friendly CPU, great for entry-level gaming.",
                    Price = 1390m,
                    Manufacturer = "Intel",
                    ModelNumber = "BX8070110400F",
                    ProductCategory = ProductCategory.CPU,
                    CpuCores = 6,
                    Threads = 12,
                    BaseClockSpeed = 2.9,
                    BoostClockSpeed = 4.3,
                    Socket = "LGA1200"
                },
                new Processor
                {
                    Id = 8,
                    Name = "Intel Core i5-11600K",
                    Description = "6-core 11th gen CPU with strong single-core performance.",
                    Price = 2190m,
                    Manufacturer = "Intel",
                    ModelNumber = "BX8070811600K",
                    ProductCategory = ProductCategory.CPU,
                    CpuCores = 6,
                    Threads = 12,
                    BaseClockSpeed = 3.9,
                    BoostClockSpeed = 4.9,
                    Socket = "LGA1200"
                });
            #endregion

            #region Motherboards

            modelBuilder.Entity<Motherboard>().HasData(
                new Motherboard
                {
                    Id = 101,
                    Name = "MSI B650M Mortar WiFi",
                    Description = "Micro-ATX motherboard for AMD Ryzen with PCIe 4.0 and DDR5 support.",
                    Price = 1990m,
                    Manufacturer = "MSI",
                    ModelNumber = "B650M-MORTAR-WIFI",
                    ProductCategory = ProductCategory.Motherboard,
                    Chipset = "B650",
                    Socket = "AM5",
                    FormFactor = "Micro-ATX",
                    MemmoryType = "DDR5",
                    M2Slots = 2

                },
                new Motherboard
                {
                    Id = 102,
                    Name = "ASUS ROG Strix Z790-E Gaming WiFi",
                    Description = "Premium Intel Z790 motherboard with high-end features for gamers.",
                    Price = 4290m,
                    Manufacturer = "ASUS",
                    ModelNumber = "90MB1CW0-M0EAY0",
                    ProductCategory = ProductCategory.Motherboard,
                    Chipset = "Z790",
                    Socket = "LGA1700",
                    FormFactor = "ATX",
                    MemmoryType = "DDR5",
                    M2Slots = 4

                },
                new Motherboard
                {
                    Id = 103,
                    Name = "Gigabyte B550 AORUS Elite V2",
                    Description = "Affordable AM4 motherboard with strong VRM and PCIe 4.0.",
                    Price = 1390m,
                    Manufacturer = "Gigabyte",
                    ModelNumber = "B550-AORUS-ELITE-V2",
                    ProductCategory = ProductCategory.Motherboard,
                    Chipset = "B550",
                    Socket = "AM4",
                    FormFactor = "ATX",
                    MemmoryType = "DDR4",
                    M2Slots = 2

                },
                new Motherboard
                {
                    Id = 104,
                    Name = "ASUS PRIME B460M-A",
                    Description = "Entry-level Intel motherboard with solid features for budget builds.",
                    Price = 990m,
                    Manufacturer = "ASUS",
                    ModelNumber = "B460M-A",
                    ProductCategory = ProductCategory.Motherboard,
                    Chipset = "B460",
                    Socket = "LGA1200",
                    FormFactor = "Micro-ATX",
                    MemmoryType = "DDR4",
                    M2Slots = 1

                },
                new Motherboard
                {
                    Id = 105,
                    Name = "ASRock X670E Taichi",
                    Description = "Flagship AM5 motherboard with PCIe 5.0 and robust power delivery.",
                    Price = 5890m,
                    Manufacturer = "ASRock",
                    ModelNumber = "X670E-TAICHI",
                    ProductCategory = ProductCategory.Motherboard,
                    Chipset = "X670E",
                    Socket = "AM5",
                    FormFactor = "ATX",
                    MemmoryType = "DDR5",
                    M2Slots = 4

                },
                new Motherboard
                {
                    Id = 106,
                    Name = "MSI PRO Z690-A DDR4",
                    Description = "Well-balanced Z690 motherboard with DDR4 support for 12th gen Intel CPUs.",
                    Price = 2190m,
                    Manufacturer = "MSI",
                    ModelNumber = "Z690-A-PRO-DDR4",
                    ProductCategory = ProductCategory.Motherboard,
                    Chipset = "Z690",
                    Socket = "LGA1700",
                    FormFactor = "ATX",
                    MemmoryType = "DDR4",
                    M2Slots = 3

                });
            #endregion

            #region Graphiccards


            modelBuilder.Entity<GraphicCard>().HasData(
                new GraphicCard
                {
                    Id = 201,
                    Name = "NVIDIA GeForce RTX 4070 Ti",
                    Description = "High-end gaming GPU with ray tracing and DLSS 3.",
                    Price = 9290m,
                    Manufacturer = "NVIDIA",
                    ModelNumber = "RTX4070TI-12G",
                    ProductCategory = ProductCategory.Graphic_Card,
                    VramMemory = 12,
                    Chipset = "Ada Lovelace"

                },
                new GraphicCard
                {
                    Id = 202,
                    Name = "AMD Radeon RX 7900 XT",
                    Description = "Powerful RDNA 3 architecture with high VRAM for 4K gaming.",
                    Price = 8790m,
                    Manufacturer = "AMD",
                    ModelNumber = "RX7900XT-20G",
                    ProductCategory = ProductCategory.Graphic_Card,
                    VramMemory = 20,
                    Chipset = "RDNA 3"

                },
                new GraphicCard
                {
                    Id = 203,
                    Name = "NVIDIA GeForce RTX 3060",
                    Description = "Budget-friendly GPU with solid 1080p performance.",
                    Price = 3490m,
                    Manufacturer = "NVIDIA",
                    ModelNumber = "RTX3060-12G",
                    ProductCategory = ProductCategory.Graphic_Card,
                    VramMemory = 12,
                    Chipset = "Ampere"

                },
                new GraphicCard
                {
                    Id = 204,
                    Name = "AMD Radeon RX 6750 XT",
                    Description = "Strong 1440p performance with fast memory bandwidth.",
                    Price = 4590m,
                    Manufacturer = "AMD",
                    ModelNumber = "RX6750XT-12G",
                    ProductCategory = ProductCategory.Graphic_Card,
                    VramMemory = 12,
                    Chipset = "RDNA 2"

                },
                new GraphicCard
                {
                    Id = 205,
                    Name = "Intel Arc A770",
                    Description = "Intel's high-end GPU with Xe HPG architecture.",
                    Price = 3990m,
                    Manufacturer = "Intel",
                    ModelNumber = "ARC-A770-16G",
                    ProductCategory = ProductCategory.Graphic_Card,
                    VramMemory = 16,
                    Chipset = "Alchemist"

                },
                new GraphicCard
                {
                    Id = 206,
                    Name = "NVIDIA GeForce GTX 1660 Super",
                    Description = "Reliable mid-range GPU for 1080p gaming.",
                    Price = 2290m,
                    Manufacturer = "NVIDIA",
                    ModelNumber = "GTX1660S-6G",
                    ProductCategory = ProductCategory.Graphic_Card,
                    VramMemory = 6,
                    Chipset = "Turing"

                });
            #endregion

            #region Power Supplies

            modelBuilder.Entity<PowerSupply>().HasData(
                new PowerSupply
                {
                    Id = 301,
                    Name = "Corsair RM750x",
                    Description = "750W 80+ Gold Certified Fully Modular",
                    Price = 1299,
                    Manufacturer = "Corsair",
                    ModelNumber = "CP-9020179-EU",
                    ProductCategory = ProductCategory.Power_Supply,
                    Wattage = 750,
                    EfficiencyRating = "80+ Gold",
                    Modularity = "Modular",
                    Formfactor = "ATX"

                },
                new PowerSupply
                {
                    Id = 302,
                    Name = "Seasonic Focus GX-650",
                    Description = "650W 80+ Gold Fully Modular PSU",
                    Price = 1149,
                    Manufacturer = "Seasonic",
                    ModelNumber = "FOCUS-GX-650",
                    ProductCategory = ProductCategory.Power_Supply,
                    Wattage = 650,
                    EfficiencyRating = "80+ Gold",
                    Modularity = "Modular",
                    Formfactor = "ATX"

                },
                new PowerSupply
                {
                    Id = 303,
                    Name = "be quiet! Straight Power 11",
                    Description = "850W 80+ Platinum Fully Modular",
                    Price = 1799,
                    Manufacturer = "be quiet!",
                    ModelNumber = "BN641",
                    ProductCategory = ProductCategory.Power_Supply,
                    Wattage = 850,
                    EfficiencyRating = "80+ Platinum",
                    Modularity = "Modular",
                    Formfactor = "ATX"

                },
                new PowerSupply
                {
                    Id = 304,
                    Name = "EVGA 600 BR",
                    Description = "600W 80+ Bronze Non-Modular",
                    Price = 699,
                    Manufacturer = "EVGA",
                    ModelNumber = "100-BR-0600-K1",
                    ProductCategory = ProductCategory.Power_Supply,
                    Wattage = 600,
                    EfficiencyRating = "80+ Bronze",
                    Modularity = "Non-Modular",
                    Formfactor = "ATX"

                },
                new PowerSupply
                {
                    Id = 305,
                    Name = "Cooler Master MWE Bronze 550",
                    Description = "550W 80+ Bronze Semi Modular",
                    Price = 749,
                    Manufacturer = "Cooler Master",
                    ModelNumber = "MPX-5501-ACAAB",
                    ProductCategory = ProductCategory.Power_Supply,
                    Wattage = 550,
                    EfficiencyRating = "80+ Bronze",
                    Modularity = "Semi-Modular",
                    Formfactor = "ATX"

                },
                new PowerSupply
                {
                    Id = 306,
                    Name = "Fractal Design Ion+ 760P",
                    Description = "760W 80+ Platinum Fully Modular",
                    Price = 1549,
                    Manufacturer = "Fractal Design",
                    ModelNumber = "FD-PSU-IONP-760P-BK",
                    ProductCategory = ProductCategory.Power_Supply,
                    Wattage = 760,
                    EfficiencyRating = "80+ Platinum",
                    Modularity = "Modular",
                    Formfactor = "ATX"

                });
            #endregion

            #region SSDs

            modelBuilder.Entity<SolidStateDrive>().HasData(
                new SolidStateDrive
                {
                    Id = 401,
                    Name = "Samsung 980 PRO",
                    Description = "NVMe M.2 SSD with high-performance Gen4 speed",
                    Price = 1599,
                    Manufacturer = "Samsung",
                    ModelNumber = "MZ-V8P1T0BW",
                    ProductCategory = ProductCategory.Solid_State_Drive,
                    CapacityGb = "1000",
                    ReadSpeed = 7000,
                    WriteSpeed = 5000,
                    Interface = "NVMe",
                    ExpectedLifetime = 1500000,
                    FormFactor = "M.2"

                },
                new SolidStateDrive
                {
                    Id = 402,
                    Name = "Crucial MX500",
                    Description = "Reliable 2.5'' SATA SSD with integrated power loss immunity",
                    Price = 899,
                    Manufacturer = "Crucial",
                    ModelNumber = "CT1000MX500SSD1",
                    ProductCategory = ProductCategory.Solid_State_Drive,
                    CapacityGb = "1000",
                    ReadSpeed = 560,
                    WriteSpeed = 510,
                    Interface = "SATA",
                    ExpectedLifetime = 1800000,
                    FormFactor = "2.5"

                },
                new SolidStateDrive
                {
                    Id = 403,
                    Name = "WD Black SN850X",
                    Description = "High-end PCIe Gen4 NVMe SSD for gaming",
                    Price = 1399,
                    Manufacturer = "Western Digital",
                    ModelNumber = "WDS100T2X0E",
                    ProductCategory = ProductCategory.Solid_State_Drive,
                    CapacityGb = "1000",
                    ReadSpeed = 7300,
                    WriteSpeed = 6300,
                    Interface = "NVMe",
                    ExpectedLifetime = 1600000,
                    FormFactor = "M.2"

                },
                new SolidStateDrive
                {
                    Id = 404,
                    Name = "Kingston A400",
                    Description = "Budget-friendly SATA SSD",
                    Price = 499,
                    Manufacturer = "Kingston",
                    ModelNumber = "SA400S37/480G",
                    ProductCategory = ProductCategory.Solid_State_Drive,
                    CapacityGb = "480",
                    ReadSpeed = 500,
                    WriteSpeed = 450,
                    Interface = "SATA",
                    ExpectedLifetime = 1000000,
                    FormFactor = "2.5"

                },
                new SolidStateDrive
                {
                    Id = 405,
                    Name = "Intel 670p",
                    Description = "QLC NVMe SSD for everyday computing",
                    Price = 849,
                    Manufacturer = "Intel",
                    ModelNumber = "SSDPEKNU010TZX1",
                    ProductCategory = ProductCategory.Solid_State_Drive,
                    CapacityGb = "1000",
                    ReadSpeed = 3500,
                    WriteSpeed = 2700,
                    Interface = "NVMe",
                    ExpectedLifetime = 1000000,
                    FormFactor = "M.2"

                },
                new SolidStateDrive
                {
                    Id = 406,
                    Name = "Sabrent Rocket Q4",
                    Description = "M.2 NVMe SSD with PCIe Gen4 support",
                    Price = 1299,
                    Manufacturer = "Sabrent",
                    ModelNumber = "SB-RKTQ4-1TB",
                    ProductCategory = ProductCategory.Solid_State_Drive,
                    CapacityGb = "1000",
                    ReadSpeed = 4700,
                    WriteSpeed = 1800,
                    Interface = "NVMe",
                    ExpectedLifetime = 1400000,
                    FormFactor = "M.2"

                });
            #endregion

            #region Hard Drives(HDD)

            modelBuilder.Entity<Hdd>().HasData(
                new Hdd
                {
                    Id = 501,
                    Name = "Seagate Barracuda",
                    Description = "Reliable desktop hard drive with large storage capacity",
                    Price = 749,
                    Manufacturer = "Seagate",
                    ModelNumber = "ST2000DM008",
                    ProductCategory = ProductCategory.Harddrive,
                    CapacityGb = "2000",
                    ReadSpeed = 160,
                    WriteSpeed = 150,
                    Interface = "SATA",
                    ExpectedLifetime = 1000000,
                    Rpm = "7200"

                },
                new Hdd
                {
                    Id = 502,
                    Name = "WD Blue",
                    Description = "Standard desktop HDD ideal for everyday computing",
                    Price = 699,
                    Manufacturer = "Western Digital",
                    ModelNumber = "WD10EZEX",
                    ProductCategory = ProductCategory.Harddrive,
                    CapacityGb = "1000",
                    ReadSpeed = 150,
                    WriteSpeed = 140,
                    Interface = "SATA",
                    ExpectedLifetime = 800000,
                    Rpm = "7200"

                },
                new Hdd
                {
                    Id = 503,
                    Name = "Toshiba P300",
                    Description = "Performance HDD for desktop systems",
                    Price = 829,
                    Manufacturer = "Toshiba",
                    ModelNumber = "HDWD120UZSVA",
                    ProductCategory = ProductCategory.Harddrive,
                    CapacityGb = "2000",
                    ReadSpeed = 160,
                    WriteSpeed = 150,
                    Interface = "SATA",
                    ExpectedLifetime = 1000000,
                    Rpm = "7200"

                },
                new Hdd
                {
                    Id = 504,
                    Name = "Seagate IronWolf",
                    Description = "NAS-optimized HDD with high durability",
                    Price = 1299,
                    Manufacturer = "Seagate",
                    ModelNumber = "ST4000VN008",
                    ProductCategory = ProductCategory.Harddrive,
                    CapacityGb = "4000",
                    ReadSpeed = 180,
                    WriteSpeed = 170,
                    Interface = "SATA",
                    ExpectedLifetime = 1800000,
                    Rpm = "5900"

                },
                new Hdd
                {
                    Id = 505,
                    Name = "WD Black Performance",
                    Description = "High-performance HDD for gaming and media workstations",
                    Price = 999,
                    Manufacturer = "Western Digital",
                    ModelNumber = "WD2003FZEX",
                    ProductCategory = ProductCategory.Harddrive,
                    CapacityGb = "2000",
                    ReadSpeed = 180,
                    WriteSpeed = 160,
                    Interface = "SATA",
                    ExpectedLifetime = 1200000,
                    Rpm = "7200"

                },
                new Hdd
                {
                    Id = 506,
                    Name = "HGST Ultrastar",
                    Description = "Enterprise-grade hard disk drive for long-term storage",
                    Price = 1399,
                    Manufacturer = "HGST",
                    ModelNumber = "HUH721010ALE600",
                    ProductCategory = ProductCategory.Harddrive,
                    CapacityGb = "10000",
                    ReadSpeed = 210,
                    WriteSpeed = 200,
                    Interface = "SATA",
                    ExpectedLifetime = 2500000,
                    Rpm = "7200"

                });
            #endregion

            #region Water Coolers

            modelBuilder.Entity<WaterCooler>().HasData(
                new WaterCooler
                {
                    Id = 601,
                    Name = "EK-AIO Elite 360 D-RGB",
                    Description = "Premium 360mm AIO with high RPM pump and vivid RGB.",
                    Price = 2699,
                    Manufacturer = "EKWB",
                    ModelNumber = "3831109863489",
                    ProductCategory = ProductCategory.Water_Cooler,
                    RadiatorSize = 360,
                    PumpSpeed = 3100,
                    FanSize = 120,
                    SocketCompatibility = "AM4, LGA1700, LGA1200",
                    MaxTdpWatts = 350,
                    NoiseLevel = 29.0,
                    HasRgb = true

                },
                new WaterCooler
                {
                    Id = 602,
                    Name = "Arctic Liquid Freezer II 280",
                    Description = "Powerful cooling with integrated VRM fan.",
                    Price = 1299,
                    Manufacturer = "Arctic",
                    ModelNumber = "ACFRE00063A",
                    ProductCategory = ProductCategory.Water_Cooler,
                    RadiatorSize = 280,
                    PumpSpeed = 2000,
                    FanSize = 140,
                    SocketCompatibility = "AM4, LGA1700",
                    MaxTdpWatts = 250,
                    NoiseLevel = 22.5,
                    HasRgb = false

                },
                new WaterCooler
                {
                    Id = 603,
                    Name = "Cooler Master MasterLiquid ML240L V2",
                    Description = "Budget-friendly 240mm AIO cooler with RGB fans.",
                    Price = 999,
                    Manufacturer = "Cooler Master",
                    ModelNumber = "MLW-D24M-A18PC-R2",
                    ProductCategory = ProductCategory.Water_Cooler,
                    RadiatorSize = 240,
                    PumpSpeed = 2600,
                    FanSize = 120,
                    SocketCompatibility = "AM4, LGA1700, LGA1200",
                    MaxTdpWatts = 200,
                    NoiseLevel = 27.0,
                    HasRgb = true

                },
                new WaterCooler
                {
                    Id = 604,
                    Name = "be quiet! Silent Loop 2",
                    Description = "Ultra-quiet 360mm AIO water cooler for powerful CPUs.",
                    Price = 2299,
                    Manufacturer = "be quiet!",
                    ModelNumber = "BW011",
                    ProductCategory = ProductCategory.Water_Cooler,
                    RadiatorSize = 360,
                    PumpSpeed = 2800,
                    FanSize = 120,
                    SocketCompatibility = "AM4, LGA1700, TR4",
                    MaxTdpWatts = 300,
                    NoiseLevel = 20.4,
                    HasRgb = false

                },
                new WaterCooler
                {
                    Id = 605,
                    Name = "NZXT Kraken X63",
                    Description = "AIO 280mm CPU cooler with RGB and quiet operation.",
                    Price = 1899,
                    Manufacturer = "NZXT",
                    ModelNumber = "RL-KRX63-01",
                    ProductCategory = ProductCategory.Water_Cooler,
                    RadiatorSize = 280,
                    PumpSpeed = 3000,
                    FanSize = 140,
                    SocketCompatibility = "AM4, LGA1200, LGA1700",
                    MaxTdpWatts = 280,
                    NoiseLevel = 21.5,
                    HasRgb = true

                },
                new WaterCooler
                {
                    Id = 606,
                    Name = "Corsair H100i RGB Platinum",
                    Description = "High-performance 240mm liquid CPU cooler with RGB fans.",
                    Price = 1599,
                    Manufacturer = "Corsair",
                    ModelNumber = "CW-9060039-WW",
                    ProductCategory = ProductCategory.Water_Cooler,
                    RadiatorSize = 240,
                    PumpSpeed = 2700,
                    FanSize = 120,
                    SocketCompatibility = "AM4, LGA1200, LGA1700",
                    MaxTdpWatts = 250,
                    NoiseLevel = 25.0,
                    HasRgb = true

                });
            #endregion

            #region Air Coolers

            modelBuilder.Entity<AirCooler>().HasData(
                new AirCooler
                {
                    Id = 701,
                    Name = "DeepCool AK620",
                    Description = "Balanced dual-tower cooler with stylish design.",
                    Price = 799,
                    Manufacturer = "DeepCool",
                    ModelNumber = "R-AK620-BKNNMT-G-1",
                    ProductCategory = ProductCategory.Air_Cooler,
                    FanSize = 120,
                    Height = 160,
                    FanSpeed = 1850,
                    HeatPipes = 6,
                    SocketCompatibility = "AM4, LGA1700, LGA1200",
                    MaxTdpWatts = 260,
                    NoiseLevel = 28.0,
                    HasRgb = true

                },
                new AirCooler
                {
                    Id = 702,
                    Name = "Thermalright Peerless Assassin 120",
                    Description = "High-performance cooler with dual fans at a great price.",
                    Price = 649,
                    Manufacturer = "Thermalright",
                    ModelNumber = "PA120",
                    ProductCategory = ProductCategory.Air_Cooler,
                    FanSize = 120,
                    Height = 157,
                    FanSpeed = 1550,
                    HeatPipes = 6,
                    SocketCompatibility = "AM4, LGA1700",
                    MaxTdpWatts = 220,
                    NoiseLevel = 25.6,
                    HasRgb = false

                },
                new AirCooler
                {
                    Id = 703,
                    Name = "Scythe Fuma 2 Rev.B",
                    Description = "Efficient dual-fan cooler with low noise and height.",
                    Price = 699,
                    Manufacturer = "Scythe",
                    ModelNumber = "SCFM-2000",
                    ProductCategory = ProductCategory.Air_Cooler,
                    FanSize = 120,
                    Height = 154.5,
                    FanSpeed = 1200,
                    HeatPipes = 6,
                    SocketCompatibility = "AM4, LGA1700",
                    MaxTdpWatts = 200,
                    NoiseLevel = 23.0,
                    HasRgb = true

                },
                new AirCooler
                {
                    Id = 704,
                    Name = "Cooler Master Hyper 212 Black Edition",
                    Description = "Popular budget-friendly cooler with solid performance.",
                    Price = 499,
                    Manufacturer = "Cooler Master",
                    ModelNumber = "RR-212S-20PK-R1",
                    ProductCategory = ProductCategory.Air_Cooler,
                    FanSize = 120,
                    Height = 159,
                    FanSpeed = 1800,
                    HeatPipes = 4,
                    SocketCompatibility = "AM4, LGA1700",
                    MaxTdpWatts = 150,
                    NoiseLevel = 26.0,
                    HasRgb = false

                },
                new AirCooler
                {
                    Id = 705,
                    Name = "be quiet! Dark Rock Pro 4",
                    Description = "Silent dual-tower cooler with excellent heat dissipation.",
                    Price = 899,
                    Manufacturer = "be quiet!",
                    ModelNumber = "BK022",
                    ProductCategory = ProductCategory.Air_Cooler,
                    FanSize = 135,
                    Height = 162,
                    FanSpeed = 1500,
                    HeatPipes = 7,
                    SocketCompatibility = "AM4, LGA1700",
                    MaxTdpWatts = 250,
                    NoiseLevel = 24.3,
                    HasRgb = true

                },
                new AirCooler
                {
                    Id = 706,
                    Name = "Noctua NH-D15",
                    Description = "High-end dual-tower air cooler with excellent performance.",
                    Price = 999,
                    Manufacturer = "Noctua",
                    ModelNumber = "NH-D15",
                    ProductCategory = ProductCategory.Air_Cooler,
                    FanSize = 140,
                    Height = 165,
                    FanSpeed = 1500,
                    HeatPipes = 6,
                    SocketCompatibility = "AM4, LGA1700, LGA1200",
                    MaxTdpWatts = 220,
                    NoiseLevel = 24.6,
                    HasRgb = true

                });
            #endregion

            #region RAM

            modelBuilder.Entity<Ram>().HasData(
                new Ram
                {
                    Id = 801,
                    Name = "TeamGroup T-Force Delta RGB",
                    Description = "Gaming RAM with vibrant RGB lighting.",
                    Price = 1599,
                    Manufacturer = "TeamGroup",
                    ModelNumber = "FF3D532G7200HC34ADC01",
                    ProductCategory = ProductCategory.RAM,
                    CapacityGb = 32,
                    SpeedMhz = 7200,
                    Type = "DDR5",
                    Latency = "CL34"

                },
                new Ram
                {
                    Id = 802,
                    Name = "Patriot Viper Steel",
                    Description = "Performance RAM without the flash.",
                    Price = 1199,
                    Manufacturer = "Patriot",
                    ModelNumber = "PVS416G360C8K",
                    ProductCategory = ProductCategory.RAM,
                    CapacityGb = 16,
                    SpeedMhz = 3600,
                    Type = "DDR4",
                    Latency = "CL18"

                },
                new Ram
                {
                    Id = 803,
                    Name = "Corsair Dominator Platinum RGB",
                    Description = "Premium RAM with powerful RGB and speed.",
                    Price = 1799,
                    Manufacturer = "Corsair",
                    ModelNumber = "CMT32GX5M2B5600C36",
                    ProductCategory = ProductCategory.RAM,
                    CapacityGb = 32,
                    SpeedMhz = 5600,
                    Type = "DDR5",
                    Latency = "CL36"

                },
                new Ram
                {
                    Id = 804,
                    Name = "Kingston Fury Beast",
                    Description = "Reliable RAM for gaming builds.",
                    Price = 749,
                    Manufacturer = "Kingston",
                    ModelNumber = "KF432C16BBK2/16",
                    ProductCategory = ProductCategory.RAM,
                    CapacityGb = 16,
                    SpeedMhz = 3200,
                    Type = "DDR4",
                    Latency = "CL16"

                },
                new Ram
                {
                    Id = 805,
                    Name = "G.Skill Trident Z RGB",
                    Description = "Stylish RGB RAM with high clock speeds.",
                    Price = 1399,
                    Manufacturer = "G.Skill",
                    ModelNumber = "F4-3600C18D-16GTZR",
                    ProductCategory = ProductCategory.RAM,
                    CapacityGb = 16,
                    SpeedMhz = 3600,
                    Type = "DDR4",
                    Latency = "CL18"

                },
                new Ram
                {
                    Id = 806,
                    Name = "Corsair Vengeance LPX",
                    Description = "High-performance DDR4 memory for gaming and multitasking.",
                    Price = 899,
                    Manufacturer = "Corsair",
                    ModelNumber = "CMK16GX4M2B3200C16",
                    ProductCategory = ProductCategory.RAM,
                    CapacityGb = 16,
                    SpeedMhz = 3200,
                    Type = "DDR4",
                    Latency = "CL16"

                });
            #endregion

            #region Chassis

            modelBuilder.Entity<Chassi>().HasData(
                new Chassi
                {
                    Id = 901,
                    Name = "NZXT H510",
                    Description = "Mid-tower with minimalist design and tempered glass side panel.",
                    Price = 899,
                    Manufacturer = "NZXT",
                    ModelNumber = "CA-H510B-B1",
                    ProductCategory = ProductCategory.Case,
                    TowerSize = "Mid Tower",
                    FormFactor = "ATX",
                    MotherboardSupport = "ATX, Micro-ATX, Mini-ITX",
                    WaterCoolerSupport = true

                },
                new Chassi
                {
                    Id = 902,
                    Name = "Fractal Design Meshify C",
                    Description = "Compact mid-tower with excellent airflow and modern design.",
                    Price = 999,
                    Manufacturer = "Fractal Design",
                    ModelNumber = "FD-CA-MESH-C-BKO-TG",
                    ProductCategory = ProductCategory.Case,
                    TowerSize = "Mid Tower",
                    FormFactor = "ATX",
                    MotherboardSupport = "ATX, Micro-ATX, Mini-ITX",
                    WaterCoolerSupport = true

                },
                new Chassi
                {
                    Id = 903,
                    Name = "Cooler Master MasterBox Q300L",
                    Description = "Compact case with modular design and dust filters.",
                    Price = 599,
                    Manufacturer = "Cooler Master",
                    ModelNumber = "MCB-Q300L-KANN-S00",
                    ProductCategory = ProductCategory.Case,
                    TowerSize = "Mini Tower",
                    FormFactor = "Micro-ATX",
                    MotherboardSupport = "Micro-ATX, Mini-ITX",
                    WaterCoolerSupport = false

                },
                new Chassi
                {
                    Id = 904,
                    Name = "Lian Li PC-O11 Dynamic",
                    Description = "Showcase chassis with dual-chamber design and tempered glass.",
                    Price = 1399,
                    Manufacturer = "Lian Li",
                    ModelNumber = "PC-O11DW",
                    ProductCategory = ProductCategory.Case,
                    TowerSize = "Mid Tower",
                    FormFactor = "ATX",
                    MotherboardSupport = "ATX, Micro-ATX, Mini-ITX, E-ATX",
                    WaterCoolerSupport = true

                },
                new Chassi
                {
                    Id = 905,
                    Name = "Phanteks Eclipse P400A",
                    Description = "High airflow case with mesh front panel and RGB lighting.",
                    Price = 1099,
                    Manufacturer = "Phanteks",
                    ModelNumber = "PH-EC400ATG_DWT01",
                    ProductCategory = ProductCategory.Case,
                    TowerSize = "Mid Tower",
                    FormFactor = "ATX",
                    MotherboardSupport = "ATX, Micro-ATX, Mini-ITX",
                    WaterCoolerSupport = true

                },
                new Chassi
                {
                    Id = 906,
                    Name = "Thermaltake Core V21",
                    Description = "Cube-style micro ATX case with versatile layout options.",
                    Price = 649,
                    Manufacturer = "Thermaltake",
                    ModelNumber = "CA-1D5-00S1WN-00",
                    ProductCategory = ProductCategory.Case,
                    TowerSize = "Micro Tower",
                    FormFactor = "Micro-ATX",
                    MotherboardSupport = "Micro-ATX, Mini-ITX",
                    WaterCoolerSupport = true

                });
            #endregion


            base.OnModelCreating(modelBuilder);
        }

    }
}
