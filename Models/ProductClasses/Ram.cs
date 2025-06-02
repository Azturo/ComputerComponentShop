using ComputerComponentShop.Models.BaseClasses;

namespace ComputerComponentShop.Models.ProductClasses
{
    public class Ram : Product
    {
        public int CapacityGb { get; set; }
        public int SpeedMhz { get; set; } 
        public string Type { get; set; } //DDR 4,5
        public string Latency { get; set; } //CL 16 tex
        public Ram() { }

        
    }
}
