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
    }
}
