using ComputerComponentShop.Models.BaseClasses;

namespace ComputerComponentShop.Models.ProductClasses
{
    public class PowerSupply : Product
    {
        public int Wattage { get; set; }
        public string EfficiencyRating { get; set; }
        public string Modularity { get; set; } //Modulärt, semi modulärt
        public string Formfactor { get; set; }
        public PowerSupply() { }

        
    }
}
