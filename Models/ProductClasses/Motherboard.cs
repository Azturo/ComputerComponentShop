using System.Numerics;
using ComputerComponentShop.Models.BaseClasses;

namespace ComputerComponentShop.Models.ProductClasses
{
    public class Motherboard : Product
    {
        public string Chipset { get; set; }
        public string Socket { get; set; }
        public string FormFactor { get; set; }
        public string MemmoryType { get; set; }
        public int M2Slots { get; set; }
        public Motherboard() { }

        
    }
}
