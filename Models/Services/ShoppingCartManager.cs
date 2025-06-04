using System.Threading.Tasks;
using ComputerComponentShop.Models.BaseClasses;
using ComputerComponentShop.Models.ProductEnums;
using ComputerComponentShop.Models.Services;

namespace ComputerComponentShop.Models.Services
{
    public class ShoppingCartManager
    {
        private readonly AlertService _alertService;
        private IListManager<ShoppingCartModel> _shoppingCartList;
        private string aAlertMessage = string.Empty;

        public event Action? OnChange; 
        public ShoppingCartManager(AlertService aAlertService) 
        {
            _shoppingCartList = new ListManager<ShoppingCartModel>();
            _alertService =  aAlertService;
            
        }

        public ShoppingCartManager()
        {
            _shoppingCartList = new ListManager<ShoppingCartModel>();
        }

        /// <summary>
        /// Decreases the quantity of a product in the cart. If count reaches 0 remove the product aswell
        /// </summary>
        /// <param name="aProduct"></param>
        public async void DecreaseQtyInCart(ShoppingCartModel aProduct)
        {
            if(aProduct.Quantity != 0)
            {
                aProduct.Quantity -= 1;

                if(aProduct.Quantity == 0)
                {
                    await RemoveProductFromCart(aProduct);
                }
            }
            
        }
        /// <summary>
        /// Increases the quantity of a product
        /// </summary>
        /// <param name="aProduct"></param>
        public void IncreaseQtyInCart(ShoppingCartModel aProduct)
        {
            aProduct.Quantity += 1;
        }

        /// <summary>
        /// Removes a product from the shopping cart, triggers the OnChange Event to display the alert Message in the UI
        /// </summary>
        /// <param name="aProduct"></param>
        /// <returns></returns>
        public async Task RemoveProductFromCart(ShoppingCartModel aProduct)
        {
            _shoppingCartList.Remove(aProduct);
            aAlertMessage = ($"{aProduct.Product.Name} was removed from the cart");

            await _alertService.ShowAsync(aAlertMessage);

            OnChange?.Invoke();
        }

        /// <summary>
        /// Adds a product to the shipping cart. Also triggers the OnChange Event to display the alert Message in the UI
        /// </summary>
        /// <param name="aProduct"></param>
        /// <param name="aQuantity"></param>
        /// <returns></returns>
        public async Task AddProductsToCart(Product aProduct, int aQuantity)
        {
            var aDuplicateProduct = _shoppingCartList
                .ToList()
                .FirstOrDefault(aItem => aItem.Product.Name == aProduct.Name);

            if(aDuplicateProduct != null)
            {
                aDuplicateProduct.Quantity += aQuantity;
            }
            else
            {
                var aNewProduct = new ShoppingCartModel(aProduct, aQuantity);

                _shoppingCartList.Add(aNewProduct);
                aAlertMessage = ($"{aProduct.Name} was added to the cart");
            }

            await _alertService.ShowAsync(aAlertMessage);

            OnChange?.Invoke();
        }

        /// <summary>
        /// Clears the shopping cart list
        /// </summary>
        public void ClearCart()
        {
            _shoppingCartList.DeleteAll();
        }

        
        /// <summary>
        /// Gets the shopping cart list
        /// </summary>
        /// <returns></returns>
        public List<ShoppingCartModel> GetShoppingCart()
        {
            return _shoppingCartList.ToList();
        }

        /// <summary>
        /// Sums up the products price in the cart
        /// </summary>
        /// <returns>The sum of the products in the list</returns>
        public decimal GetCartSum()
        {
            var sTotalSum = GetShoppingCart()
                            .Sum(p => p.Product.Price * p.Quantity);

            return sTotalSum;
        }

        /// <summary>
        /// Completes the purchase
        /// </summary>
        /// <param name="aCustomer"></param>
        /// <returns>The Order</returns>
        public Order? CompletePurchase(Customer aCustomer)
        {
            
            List<ShoppingCartModel> aCart = GetShoppingCart();

            if(aCart == null || aCart.Count == 0)
            {
                return null;
            }

            decimal sTotalSumForOrder = GetCartSum(); 

            Order aNewOrder = new Order();

            foreach(var aCartItem in aCart) //Adds the products in the cart to the order
            {
                aNewOrder.Products.Add((aCartItem.Product, aCartItem.Quantity, aCartItem.Product.Price));
            }

            aCustomer.Order = aNewOrder; //Links the customer to the order

            aNewOrder.TotalSum = sTotalSumForOrder; //Sets the orders total price

            ClearCart();
            
            OnChange?.Invoke(); //Invoke the event to notify that something happend

            return aNewOrder;
        }




    }
}
