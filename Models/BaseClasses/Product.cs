using ComputerComponentShop.Models.ProductEnums;

namespace ComputerComponentShop.Models.BaseClasses
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public Product()
        {

        }

        

       
      
    }
}
