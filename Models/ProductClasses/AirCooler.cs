using ComputerComponentShop.Models.BaseClasses;

namespace ComputerComponentShop.Models.ProductClasses
{
    public class AirCooler : CpuCooler
    {
        public int FanSize { get; set; }                 
        public double Height { get; set; }                  
        public int FanSpeed { get; set; }               
        public int HeatPipes { get; set; }             
        public AirCooler() { }

        
    }
}
