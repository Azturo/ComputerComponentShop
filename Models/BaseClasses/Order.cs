namespace ComputerComponentShop.Models.BaseClasses
{
    public class Order
    {
        private static int aOrderNumber = 20000;
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal TotalSum { get; set; }
        
        public int OrderNumber { get; }

        public List<(Product Product, int Quantity, decimal Price)> Products { get; set; } = new();

        public Order() 
        {
            aOrderNumber++;
            OrderNumber = aOrderNumber;
        }



    }
}
