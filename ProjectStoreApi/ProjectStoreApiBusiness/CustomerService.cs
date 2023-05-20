using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStoreApiBusiness
{
    public class CustomerService
    {
    private readonly IRepository<Customer> _customerRepository;
    private readonly IRepository<Order> _orderRepository;

    public CustomerService(IRepository<Customer> customerRepository, IRepository<Order> orderRepository)
    {
        _customerRepository = customerRepository;
        _orderRepository = orderRepository;
    }

    public void AddCustomer(Customer customer)
    {
        // Input validation

        // Add customer to the repository
    }

    public List<Customer> SearchCustomersByName(string name)
    {
        // Input validation

        // Search customers by name in the repository
    }

    public List<Order> GetCustomerOrderHistory(Customer customer)
    {
        // Input validation

        // Retrieve customer's order history from the repository
    }
    }
}