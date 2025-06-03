using ComputerComponentShop.Models.BaseClasses;
using ComputerComponentShop.Models.ProductClasses;
using Microsoft.EntityFrameworkCore;

namespace ComputerComponentShop.Models.DataBase
{
    public class ComputerComponentRepository
    {
        private readonly ComputerComponentContext _context;

        public ComputerComponentRepository(ComputerComponentContext context)
        {
            _context = context;
        }

        public async Task<List<Processor>> GetProcessors()
        {
            return await _context.Processors.ToListAsync();
        }
        public async Task<List<Motherboard>> GetMotherBoards()
        {
            return await _context.Motherboards.ToListAsync();
        }
        public async Task<List<GraphicCard>> GetGraphicCards()
        {
            return await _context.GPUs.ToListAsync();
        }
        public async Task<List<PowerSupply>> GetPowerSupplies()
        {
            return await _context.PowerSupplies.ToListAsync();
        }
        public async Task<List<SolidStateDrive>> GetSolidStateDrives()
        {
            return await _context.SSDs.ToListAsync();
        }
        public async Task<List<Hdd>> GetHardDrives()
        {
            return await _context.HDDs.ToListAsync();
        }
        public async Task<List<WaterCooler>> GetWaterCoolers()
        {
            return await _context.WaterCoolers.ToListAsync();
        }
        public async Task<List<AirCooler>> GetAirCoolers()
        {
            return await _context.AirCoolers.ToListAsync();
        }
        public async Task<List<Chassi>> GetChassis()
        {
            return await _context.Chassis.ToListAsync();
        }
        public async Task<List<Ram>> GetRams()
        {
            return await _context.Rams.ToListAsync();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            products.AddRange(await _context.Processors.ToListAsync());
            products.AddRange(await _context.GPUs.ToListAsync());
            products.AddRange(await _context.Rams.ToListAsync());
            products.AddRange(await _context.PowerSupplies.ToListAsync());
            products.AddRange(await _context.Motherboards.ToListAsync());
            products.AddRange(await _context.AirCoolers.ToListAsync());
            products.AddRange(await _context.WaterCoolers.ToListAsync());
            products.AddRange(await _context.HDDs.ToListAsync());
            products.AddRange(await _context.SSDs.ToListAsync());
            products.AddRange(await _context.Chassis.ToListAsync());

            return products;
        }

        //public async Task<List<Product>> SearchForProducts(string aSearchString)
        //{
        //    return await _context.Products
        //        .Where(p =>
        //        EF.Functions.Like(p.Name, $"%{aSearchString}") ||
        //        EF.Functions.Like(p.Manufacturer, $"%{aSearchString}") ||
        //        EF.Functions.Like(p.ProductCategory.ToString().Replace("_"," "), $"%{aSearchString}"))
        //        .ToListAsync();

        //}
    }
}
