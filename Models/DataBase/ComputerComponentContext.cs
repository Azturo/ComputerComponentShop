using System.Runtime.CompilerServices;
using ComputerComponentShop.Models.ProductClasses;
using ComputerComponentShop.Models.ProductEnums;
using Microsoft.EntityFrameworkCore;

namespace ComputerComponentShop.Models.DataBase
{
    public class ComputerComponentContext : DbContext
    {
        public DbSet<Processor> Processors { get; set; }

        public ComputerComponentContext(DbContextOptions<ComputerComponentContext> aOptions) : base(aOptions) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                }



                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
