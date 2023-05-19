public class Order
{
    public Location StoreLocation { get; set; }
    public Customer Customer { get; set; }
    public DateTime OrderTime { get; set; }
    public List<Product> Products { get; set; }
}