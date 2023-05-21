using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStoreApiModels
{
    public class Location
    {
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Product>? Inventory { get; set; }
    // Additional properties and relationships as needed
    }
}