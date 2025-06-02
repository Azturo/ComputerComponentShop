using System.Threading;

namespace ComputerComponentShop.Models.BaseClasses
{
    public abstract class HardDrive : Product
    {
        public string CapacityGb { get; set; }
        public int ReadSpeed { get; set; }
        public int WriteSpeed { get; set; }
        public string Interface { get; set; } //NVME, Sata, Usb. Kanske göra enum här
        public int ExpectedLifetime { get; set; }

        protected HardDrive() { }
    

        
    }
}
