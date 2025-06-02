using System.Net.Sockets;
using System.Threading;
using ComputerComponentShop.Models.BaseClasses;


namespace ComputerComponentShop.Models.ProductClasses
{
    public class Chassi : Product
    {
        public string TowerSize { get; set; }
        public string FormFactor { get; set; }
        public string MotherboardSupport { get; set; }
        public bool WaterCoolerSupport { get; set; }
        public Chassi() { }

    }
}
