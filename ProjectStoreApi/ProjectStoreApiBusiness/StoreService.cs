using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectStoreApiModels;
using ProjectStoreApiRepository;

namespace ProjectStoreApiBusiness
{
    public class StoreService
    {
        private IStoreRepository _storeRepository;

        public StoreService(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public List<Store> GetAllStores()
        {
            return _storeRepository.GetAllStores();
        }

        public List<Product> GetProductsByStore(int storeId)
        {
            return _storeRepository.GetProductsByStore(storeId);
        }

        public void PlaceOrder(Order order)
        {

        // Perform any necessary business logic validations or calculations
            _storeRepository.PlaceOrder(order);
        }

        public List<Order> GetOrderHistoryByStore(int storeId)
        {
            return _storeRepository.GetOrderHistoryByStore(storeId);
        }

        public List<Order> GetOrderHistoryByCustomer(int customerId)
        {
            return _storeRepository.GetOrderHistoryByCustomer(customerId);
        }

        public List<Order> GetAllOrderHistory()
        {
            return _storeRepository.GetAllOrderHistory();
        }
        public List<Order> GetOrderHistorySorted(string sortBy)
        {
            return _storeRepository.GetOrderHistorySorted(sortBy);
        }
    
    }
}