using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStoreApiBusiness
{
    public class StoreService
{
    private readonly IRepository<Store> _storeRepository;

    public StoreService(IRepository<Store> storeRepository)
    {
        _storeRepository = storeRepository;
    }

    public void AddStore(Store store)
    {
        // Input validation

        // Add the store to the repository
        _storeRepository.Add(store);
    }

    public List<Store> GetAllStores()
    {
        // Retrieve all stores from the repository
        return _storeRepository.GetAll();
    }

    public Store GetStoreById(int storeId)
    {
        // Input validation

        // Retrieve the store from the repository by its ID
        return _storeRepository.GetById(storeId);
    }

    // Additional methods for store-related operations as needed
}

}