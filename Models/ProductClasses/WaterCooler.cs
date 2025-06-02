using ComputerComponentShop.Models.BaseClasses;

namespace ComputerComponentShop.Models.ProductClasses
{
    public class WaterCooler : CpuCooler
    {
        public int RadiatorSize { get; set; }
        public int PumpSpeed { get; set; }
        public int FanSize { get; set; }
        public WaterCooler() { }

        
    }
}
