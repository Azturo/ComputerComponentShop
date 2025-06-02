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
        public void IncreaseQtyInCart(ShoppingCartModel aProduct)
        {
            aProduct.Quantity += 1;
        }

        public async Task RemoveProductFromCart(ShoppingCartModel aProduct)
        {
            _shoppingCartList.Remove(aProduct);
            aAlertMessage = ($"{aProduct.Product.Name} was removed from the cart");

            await _alertService.ShowAsync(aAlertMessage);

            OnChange?.Invoke();
        }

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

        public void ClearCart()
        {
            _shoppingCartList.DeleteAll();
        }

        

        public List<ShoppingCartModel> GetShoppingCart()
        {
            return _shoppingCartList.ToList();


        }

        public decimal GetCartSum()
        {
            var sTotalSum = GetShoppingCart()
                            .Sum(p => p.Product.Price * p.Quantity);

            return sTotalSum;
        }

        public Order? CompletePurchase(Customer aCustomer)
        {
            
            List<ShoppingCartModel> aCart = GetShoppingCart();

            if(aCart == null || aCart.Count == 0)
            {
                return null;
            }

            decimal sTotalSumForOrder = GetCartSum();

            Order aNewOrder = new Order();

            foreach(var aCartItem in aCart)
            {
                aNewOrder.Products.Add((aCartItem.Product, aCartItem.Quantity, aCartItem.Product.Price));
            }

            aCustomer.Order = aNewOrder;

            aNewOrder.TotalSum = sTotalSumForOrder;

            ClearCart();
            
            OnChange?.Invoke();

            return aNewOrder;
        }




    }
}
