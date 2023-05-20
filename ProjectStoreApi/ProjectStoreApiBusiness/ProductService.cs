using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStoreApiBusiness
{
    public class ProductService
{
    private readonly IRepository<Product> _productRepository;

    public ProductService(IRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    public Product GetProductDetails(int productId)
    {
        // Input validation

        // Retrieve product details from the repository
    }
}

}