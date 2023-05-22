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
        // Function for user to login 
        private void Login()
        {
            Console.WriteLine("Welcome to the Store Application!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please log in to continue:");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            // Perform authentication and validation logic
            bool isLoginValid = AuthenticateUser(username, password);

            if (isLoginValid)
            {
                isLoggedIn = true;
                Console.WriteLine("Login successful!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Perform authentication logic and validate credentials
            // Return true if the username and password are valid, false otherwise
            // Let's assume the username is "admin" and the password is "password"
            return username == "admin" && password == "password";
        }

        private void SelectStore()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Store Application!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please choose a store location:");
            Console.WriteLine("1. Jacksville Location 1");
            Console.WriteLine("2. Mark Location 2");
            Console.WriteLine("3. Florida Location 3");
            Console.WriteLine("4. Maryland Location 4");
            Console.WriteLine("5. Houston Location 5");
            Console.Write("Enter the number corresponding to your desired store: ");
            string storeInput = Console.ReadLine();

            // Perform input validation and store selection logic
            if (int.TryParse(storeInput, out int storeNumber) && storeNumber >= 1 && storeNumber <= 5)
            {
                // Map store number to store location or ID
                selectedStore = GetStoreLocation(storeNumber);

                Console.WriteLine($"You have selected {selectedStore}.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SelectStore(); // Retry store selection
            }
        }
             // Funcion to get store location
        private string GetStoreLocation(int storeNumber)
        {
            // Map the store number to the corresponding store location or ID
            // You can retrieve the store location from your data store or use a predefined mapping
            // Let's assume the store locations are as follows:
            switch (storeNumber)
            {
                case 1:
                    return "Jacksville Location 1";
                case 2:
                    return "Mark Location 2";
                case 3:
                    return "Florida Location 3";
                case 4:
                    return "Maryland Location 4";
                case 5:
                    return "Houston Location 5";
                default:
                    return string.Empty;
            }
        }
    }
        // function to Add customer 
       public void AddCustomer(Customer customer)
       {
    // Validate input
       if (customer == null)
    {
        throw new ArgumentException("Invalid customer.");
    }
    
    // Save the customer to the database
   // CustomerRepository.Add(customer);
       }
       // function to Search Customer by name
    public void SearchCustomersByName(string name)
    {
    // Validate input
    if (string.IsNullOrEmpty(name))
    {
        throw new ArgumentException("Invalid name.");
    }

    // Search for customers in the database
   // return CustomerRepository.GetByName(name);
    }
    // Function to Display Order Details
    public void DisplayOrderDetails(Order order)
    {
    // Validate input
    if (order == null)
    {
        throw new ArgumentException("Invalid order.");
    }

    // Display order details
    //Console.WriteLine($"Order ID: {order.ID}");
    Console.WriteLine($"Order Time: {order.OrderTime}");
    Console.WriteLine($"Customer: {order.Customer.FirstName} {order.Customer.LastName}");
    Console.WriteLine($"Store Location: {order.StoreLocation.Name}");

    Console.WriteLine("Products:");
    foreach (Product product in order.Products)
    {
        Console.WriteLine($"- {product.Name} (${product.Price})");
    }
}
     // Function to Display lacation order history
    public void DisplayStoreOrderHistory(Location storeLocation)
{
    // Input validation
    if (storeLocation == null)
    {
        throw new ArgumentException("Invalid store location.");
    }

    // Get the order history from the database
    //List<Order> orders = OrderRepository.GetOrdersByLocation(storeLocation);

    // Display order history
    Console.WriteLine($"Order History of {storeLocation.Name}:");
    foreach (Order order in Orders)
    {
        //Console.WriteLine($"Order ID: {order.ID}");
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
    // Function to Display customer history
        public void DisplayCustomerOrderHistory(Customer customer)
{
    // Input validation
    if (customer == null)
    {
        throw new ArgumentException("Invalid customer.");
    }

    // Get the order history from the database
    //List<Order> orders = OrderRepository.GetOrdersBy;

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

        
    }
}    


