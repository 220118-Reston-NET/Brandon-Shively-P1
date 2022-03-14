using StarWarsModel;

namespace StarWarsBL{
    public interface IStarWarsStoreBL{
        Customer AddCustomer(Customer n_customer);
        List<Customer> SearchCustomer(string n_customer);
        List<Customer> GetAllCustomer();
        List<Storefront> GetAllStores();
        Storefront AddStoreFront(Storefront n_storeFront);
        List<Storefront> SearchStoreFront(string n_storeFront);
        List<Manager> ManagerLogin(string p_userName, string p_password);
        List<Customer> CustomerLogin(string p_userName, string p_password);
        List<LineItems> GetAllLineItems(int p_ID);
        List<LineItems> GetAllStoreItems(int p_ID);
        List<LineItems> ReplenishInventory(int p_ID, int p_Quantity, int p_ItemID);
        List<ShoppingCart> PlaceOrder(int p_ID, float p_Price, int p_Quantity, int p_StoreID, int p_CustomerID);
        List<Order> CustomerOrder(int p_CustomerID, string p_orderMethod);
        List<Order> StoreOrder(int p_StoreID, string p_orderMethod);

    }
}