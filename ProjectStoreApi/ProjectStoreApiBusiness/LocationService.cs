using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStoreApiBusiness
{
    public class LocationService
{
    private readonly IRepository<Location> _locationRepository;

    public LocationService(IRepository<Location> locationRepository)
    {
        _locationRepository = locationRepository;
    }

    public List<Product> GetAvailableProducts(Location storeLocation)
    {
        // Input validation

        // Retrieve available products from the location's inventory
    }

    public void UpdateInventory(Location storeLocation, List<Product> products)
    {
        // Input validation

        // Update the inventory of the store location
    }
}

}