using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Model
{
        public class Store
    {
        public Store(Guid id, string name, string address)
        {
            StoreId = id;
            Name = name;
            Address = address;
            Inventory = new List<Product>();
        }

        public Guid StoreId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Inventory { get; set; }

        




    }

}
