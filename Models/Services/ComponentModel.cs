using ComputerComponentShop.Models.BaseClasses;
using ComputerComponentShop.Models.ProductEnums;

namespace ComputerComponentShop.Models.Services
{
    public class ComponentModel
    {
        public ProductCategory ComponentCategory { get; set; }
        public IListManager<Product> Components { get; set; }
        public ComponentModel(ProductCategory aComponentCategory) 
        {
            ComponentCategory = aComponentCategory;
            Components = new ListManager<Product>();
        }




    }
}
