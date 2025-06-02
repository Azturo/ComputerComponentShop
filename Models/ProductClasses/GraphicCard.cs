using ComputerComponentShop.Models.BaseClasses;


namespace ComputerComponentShop.Models.ProductClasses
{
    public class GraphicCard : Product
    {
        public int VramMemory { get; set; }
        public string Chipset { get; set; }

        public GraphicCard() { }



        
    }
}
