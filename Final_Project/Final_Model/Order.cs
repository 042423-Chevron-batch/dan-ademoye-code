namespace Final_Model
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public Person Customer { get; set; }
        public Store Store { get; set; }
        
        public int Quantity { get; set; }

         public Product Product { get; set; } 

        public List<Product> Products { get; set; }
    }

}