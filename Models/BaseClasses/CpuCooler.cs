namespace ComputerComponentShop.Models.BaseClasses
{
    public abstract class CpuCooler : Product
    {
        public string SocketCompatibility { get; set; }
        public int MaxTdpWatts { get; set; }
        public double NoiseLevel { get; set; }
        public bool HasRgb { get; set; }
        protected CpuCooler() { }

    }
}
