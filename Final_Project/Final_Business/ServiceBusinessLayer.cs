using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Model;
using Final_Repository;

namespace Final_Business
{
    public class ServiceBusinessLayer
    {
        public List<Store> GetStores()
        {
            Repository repo = new Repository();
            List<Store> stores = repo.GetStores();

            if (stores.Count > 0)
            {
                return stores;
            }
            else
            {
                return null;
            }
        }

        public Person Login(string username, string password)
        {
            Repository repo = new Repository();
            Person p = repo.GetUserByUnamePword(username, password);
            return p;
        }

        public Person Register(RegDto dto)
        {
            Repository repo = new Repository();
            bool ret = repo.UserNamePasswordInDb(dto.UserName, dto.Password);

            if (!ret)
            {
                Person p = Mapper.RegDtoToPerson(dto);
                int numRowsAffected = repo.RegisterNewCustomer(p);

                if (numRowsAffected == 1)
                {
                    Person p1 = repo.GetUserByUnamePword(p.UserName, p.Password);
                    return p1;
                }
            }

            return null;
        }

        public Store StoreInfo(Guid storeId)
        {
            Repository repo = new Repository();
            Store s = repo.GetStoreInfo(storeId);

            if (s != null)
            {
                return s;
            }
            else
            {
                return null;
            }
        }

        
        

        public void DisplayOrderDetails(Order order)
        {
            Repository repo = new Repository();

            // Validate input
            if (order == null)
            {
                throw new ArgumentException("Invalid order.");
            }

            // Display order details
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine($"Order Time: {order.OrderTime}");
            Console.WriteLine($"Customer: {order.Customer.FirstName} {order.Customer.LastName}");
            Console.WriteLine("Products:");
            foreach (Product product in order.Products)
            {
                Console.WriteLine($"- {product.ProductName} (${product.Price})");
            }
        }

        public void DisplayStoreOrderHistory(Store store)
        {
            Repository repo = new Repository();

            // Input validation
            if (store == null)
            {
                throw new ArgumentException("Invalid store.");
            }

            // Get the order history from the database for the specified store
            List<Order> orders = GetOrdersByStore(store);

            // Display order history
            Console.WriteLine($"Order History of {store.Name}:");
            foreach (Order order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}");
                Console.WriteLine($"Order Time: {order.OrderTime}");
                Console.WriteLine($"Customer: {order.Customer.FirstName} {order.Customer.LastName}");
                Console.WriteLine("Products:");
                foreach (Product product in order.Products)
                {
                    Console.WriteLine($"- {product.ProductName} (${product.Price})");
                }
                Console.WriteLine();
            }
        }

        private List<Order> GetOrdersByStore(Store store)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByStoreId(int storeId)
        {
            throw new NotImplementedException();
        }
    }


    public class storeRepositoty
    {
        List<Store> stores = new List<Store>
        {
        new Store ( Guid.NewGuid(), "Store 1", "Address 1" ),
        new Store ( Guid.NewGuid(), "Store 2", "Address 2" ),
        new Store ( Guid.NewGuid(), "Store 3", "Address 3" ),
        };
        
    
    }

    public class ProductRepository 
    {
        private readonly List<Product> _products;

        public ProductRepository(){
            _products = new List<Product>
    {
        new Product(Guid.NewGuid(), "Product 1", 10, "Product 1 Description", 9.99m),
        new Product(Guid.NewGuid(), "Product 2", 5, "Product 2 Description", 19.99m),
        new Product(Guid.NewGuid(), "Product 3", 4, "Product 3 Description", 14.99m)
    };

        }
        

        public async Task<List<Product>> GetProductsByStoreId(int storeId)
        {
            return await Task.FromResult(_products.Where(p => p.StoreId == storeId).ToList());
        }
    }
}
