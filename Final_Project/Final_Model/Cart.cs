using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Model
{
    public class Cart
    {
      public List<CartItem> Items { get; set; } = new List<CartItem>();

    public void AddProduct(Product product, int quantity)
    {
        // Add the product to the cart or update the quantity if already present
        CartItem existingItem = Items.FirstOrDefault(item => item.Product.ProductId == product.ProductId);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            Items.Add(new CartItem { Product = product, Quantity = quantity });
        }
    }
    
    }   

// Create a new CartItem class to represent an item in the user's shopping cart
public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
}


    }
