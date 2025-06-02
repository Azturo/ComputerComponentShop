using ComputerComponentShop.Models.BaseClasses;

namespace ComputerComponentShop.Models.Services
{
    public class ShoppingCartModel
    {

        public Product Product { get; set; }
        public int Quantity { get; set; }

        public ShoppingCartModel(Product aProduct, int aQuantity) 
        {
            Product = aProduct;
            Quantity = aQuantity;
        }
    }
}
