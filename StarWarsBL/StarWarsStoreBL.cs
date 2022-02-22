using StarWarsDL;
using StarWarsModel;

namespace StarWarsBL{
    public class StarWarsStoreBL : IStarWarsStoreBL{
        private IRepository _repo;
        public StarWarsStoreBL(IRepository p_repo){
            _repo = p_repo;
        }

        public Customer AddCustomer(Customer n_customer){
        return _repo.AddCustomer(n_customer);
        }

        public Storefront AddStoreFront(Storefront n_storeFront){
            return _repo.AddStoreFront(n_storeFront);
        }

        public List<Order> CustomerOrder(int p_CustomerID)
        {
            List<Order> listOfCustomerOrders = _repo.CustomerOrder(p_CustomerID);
            return listOfCustomerOrders
                .ToList();
        }

        public List<Customer> GetAllCustomer(){
            return _repo.GetAllCustomers();
        }

        public List<LineItems> GetAllLineItems(int p_ID)
        {
            List<LineItems> listOfStoreProducts = _repo.GetAllLineItems(p_ID);
            return listOfStoreProducts
                .ToList();
        }

        public List<LineItems> GetAllStoreItems(int p_ID)
        {
            List<LineItems> listOfProducts = _repo.GetAllStoreItems(p_ID);
            return listOfProducts
                .ToList();
        }

        public List<Storefront> GetAllStores()
        {
            return _repo.GetAllStores();
        }

        public List<ShoppingCart> PlaceOrder(int p_ID, float p_Price, int p_Quantity, int p_StoreID, int p_CustomerID)
        {
            List<ShoppingCart> orderList = _repo.PlaceOrder(p_ID, p_Price, p_Quantity, p_StoreID, p_CustomerID);
            return null;
        }

        public List<LineItems> ReplenishInventory(int p_ID, int p_Quantity, int p_ItemID)
        {
            List<LineItems> listOfProducts = _repo.ReplenishInventory(p_ID, p_Quantity, p_ItemID);
            return listOfProducts
                .ToList();
        }

        public List<Customer> SearchCustomer(string n_customer){
            List<Customer> listOfCustomers = _repo.GetAllCustomers();
            return listOfCustomers
                .Where(customer => customer.Name.Contains(n_customer))
                .ToList();
        }

        public List<Storefront> SearchStoreFront(string n_storeFront){
            List<Storefront> listOfStores = _repo.GetAllStores();
            return listOfStores
                .Where(storefront => storefront.Name.Contains(n_storeFront))
                .ToList();
        }

        public List<Order> StoreOrder(int p_StoreID)
        {
            List<Order> listOfStoreOrders = _repo.StoreOrder(p_StoreID);
            return listOfStoreOrders
                .ToList();
        }
    }
}
