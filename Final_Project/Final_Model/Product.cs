using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Model
{
    public class Product
    {
    

        // this constructor is useful for when we need to extract a product from the Db and display it's data to the user.
        public Product(Guid pid, string pname, int q, string d, decimal price)
        {
            this.ProductId = pid;
            this.Description = d;
            this.ProductName = pname;
            this.Quantity = q;
            this.Price = price;
        }

        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; } = 0;
        public string Description { get; set; }

        public decimal Price { get; set; }
        public int StoreId { get; set; }

        public interface IProductRepository
    {
        Task<List<Product>> GetProductsByStoreId(int storeId);
    }
}
        
}

    