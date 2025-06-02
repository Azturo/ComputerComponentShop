using ComputerComponentShop.Models.BaseClasses;

namespace ComputerComponentShop.Models.Services
{
    public class CustomerManager
    {
        private IListManager<Customer> aCustomerList { get; set; }

        public CustomerManager() 
        {
            aCustomerList = new ListManager<Customer>();
        }

        public void AddCustomer(Customer aCustomer)
        {
            aCustomerList.Add(aCustomer);

        }

        public void ClearCustomerList()
        {
            aCustomerList.DeleteAll();
        }

        public IListManager<Customer> GetAll()
        {
            return aCustomerList;
        }

    }
}
