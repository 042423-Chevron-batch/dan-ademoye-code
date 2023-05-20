using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStoreApiBusiness
{
    public class OrderService
{
    private readonly IRepository<Order> _orderRepository;
    private readonly IRepository<Location> _locationRepository;
    private readonly IRepository<Product> _productRepository;

    public OrderService(IRepository<Order> orderRepository, IRepository<Location> locationRepository, IRepository<Product> productRepository)
    {
        _orderRepository = orderRepository;
        _locationRepository = locationRepository;
        _productRepository = productRepository;
    }

    public void PlaceOrder(Customer customer, Location storeLocation, List<Product> products)
    {
        // Input validation

        // Perform order placement logic
    }

    public Order GetOrderDetails(int orderId)
    {
        // Input validation

        // Retrieve order details from the repository
    }

    public List<Order> GetLocationOrderHistory(Location storeLocation)
    {
        // Input validation

        // Retrieve location's order history from the repository
    }
}

}