using System.Runtime.InteropServices;
using ComputerComponentShop.Models.BaseClasses;

namespace ComputerComponentShop.Models.ProductClasses
{
    public class Processor : Product
    {

        public int CpuCores { get; set; }
        public int Threads { get; set; }
        public double BaseClockSpeed { get; set; }
        public double BoostClockSpeed { get; set; }
        public string Socket { get; set; }
        
        public Processor() { }

        
    }
}
