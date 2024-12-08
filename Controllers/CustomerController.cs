using shop_management_system.Models;
using shop_management_system.Services;

namespace shop_management_system.Controllers
{
    public class CustomerController
    {
        private readonly CustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }

        public bool AddCustomer(Customer customer)
        {
            return _customerService.AddCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }
    }
}
