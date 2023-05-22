using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectStoreApiModels;
using ProjectStoreApiRepository;

namespace ProjectStoreApiBusiness
{
    public class StoreService
    {
       public void AddCustomer(Customer customer)
       {
    // Validate input
       if (customer == null)
    {
        throw new ArgumentException("Invalid customer.");
    }
    
    // Save the customer to the database
    CustomerRepository.Add(customer);
    }
    public List<Customer> SearchCustomersByName(string name)
    {
    // Validate input
    if (string.IsNullOrEmpty(name))
    {
        throw new ArgumentException("Invalid name.");
    }

    // Search for customers in the database
    return CustomerRepository.GetByName(name);
    }
    public void DisplayOrderDetails(Order order)
    {
    // Validate input
    if (order == null)
    {
        throw new ArgumentException("Invalid order.");
    }

    // Display order details
    Console.WriteLine($"Order ID: {order.ID}");
    Console.WriteLine($"Order Time: {order.OrderTime}");
    Console.WriteLine($"Customer: {order.Customer.FirstName} {order.Customer.LastName}");
    Console.WriteLine($"Store Location: {order.StoreLocation.Name}");

    Console.WriteLine("Products:");
    foreach (Product product in order.Products)
    {
        Console.WriteLine($"- {product.Name} (${product.Price})");
    }
}

    public void DisplayStoreOrderHistory(Location storeLocation)
{
    // Input validation
    if (storeLocation == null)
    {
        throw new ArgumentException("Invalid store location.");
    }

    // Get the order history from the database
    List<Order> orders = OrderRepository.GetOrdersByLocation(storeLocation);

    // Display order history
    Console.WriteLine($"Order History of {storeLocation.Name}:");
    foreach (Order order in orders)
    {
        Console.WriteLine($"Order ID: {order.ID}");
        Console.WriteLine($"Order Time: {order.OrderTime}");
        Console.WriteLine($"Customer: {order.Customer.FirstName} {order.Customer.LastName}");
        Console.WriteLine("Products:");
        foreach (Product product in order.Products)
        {
            Console.WriteLine($"- {product.Name} (${product.Price})");
        }
        Console.WriteLine();
    }
    
}
        public void DisplayCustomerOrderHistory(Customer customer)
{
    // Input validation
    if (customer == null)
    {
        throw new ArgumentException("Invalid customer.");
    }

    // Get the order history from the database
    List<Order> orders = OrderRepository.GetOrdersBy;

    }

    private void AddToCart(Product product, StoreLocation store)
    {
        Console.WriteLine($"------ Add to Cart ------");
        Console.WriteLine($"Product: {product.Name} - ${product.Price}");
        Console.WriteLine($"Store: {store.Name}");
        Console.WriteLine("-------------------------");

        Console.Write("Enter the quantity: ");
        string userInput = GetUserInput();
        if (int.TryParse(userInput, out int quantity) && quantity > 0)
        {
            bool success = storeApp.AddToCart(product, store, quantity);
            if (success)
            {
                Console.WriteLine("Product added to cart successfully!");
            }
            else
            {
                Console.WriteLine("Failed to add product to cart.");
            }
        }          
        else
        {
            Console.WriteLine("Invalid quantity. Please try again.");
        }

        Console.WriteLine("-------------------------");
        ChooseStore();
    }  
    
 }

}

