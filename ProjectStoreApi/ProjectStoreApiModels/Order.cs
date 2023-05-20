using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStoreApiModels
{
    public class Order
    {
    public int Id { get; set; }
    public DateTime OrderTime { get; set; }
    public Customer Customer { get; set; }
    public Location StoreLocation { get; set; }
    public List<Product> Products { get; set; }
    // Additional properties and relationships as needed
    }
}