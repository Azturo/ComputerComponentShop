using ComputerComponentShop.Models.BaseClasses;
using ComputerComponentShop.Models.ProductClasses;
using Microsoft.EntityFrameworkCore;

namespace ComputerComponentShop.Models.DataBase
{
    public class ComputerComponentRepository
    {
        private readonly ComputerComponentContext _context;
        private readonly List<Product> sProducts = new List<Product>();

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

            sProducts.AddRange(await _context.Processors.ToListAsync());
            sProducts.AddRange(await _context.GPUs.ToListAsync());
            sProducts.AddRange(await _context.Rams.ToListAsync());
            sProducts.AddRange(await _context.PowerSupplies.ToListAsync());
            sProducts.AddRange(await _context.Motherboards.ToListAsync());
            sProducts.AddRange(await _context.AirCoolers.ToListAsync());
            sProducts.AddRange(await _context.WaterCoolers.ToListAsync());
            sProducts.AddRange(await _context.HDDs.ToListAsync());
            sProducts.AddRange(await _context.SSDs.ToListAsync());
            sProducts.AddRange(await _context.Chassis.ToListAsync());

            return sProducts;
        }
    }
}
