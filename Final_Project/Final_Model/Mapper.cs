using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Model;

namespace Final_Model
{
    public class Mapper
    {
        public static Person RegDtoToPerson(RegDto dto)
        {
            return new Person(dto.FirstName, dto.LastName, dto.LastOrderDate, dto.Remarks, dto.UserName, dto.Password);
        }
         public static Product AddToProduct(Guid id, string name, int quantity, string desc, int Price)
        {
            Product p = new Product(id, name, quantity, desc, Price);
            return p;
        }
        public static Store AddToStore(Guid id, string name, string address)
        {
            return new Store(id, name, address);
        }



    }
    
}

