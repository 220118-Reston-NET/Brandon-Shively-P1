using StarWarsModel;

namespace StarWarsDL{
    public interface IRepository{
        Customer AddCustomer(Customer n_customer);
        List<Customer> GetAllCustomers();
        Storefront AddStoreFront(Storefront n_storeFront);
        List<LineItems> GetAllLineItems(int p_ID);
        List<LineItems> GetAllStoreItems(int p_ID);
        List<Storefront> GetAllStores();
        List<LineItems> ReplenishInventory(int p_ID, int p_Quantity, int p_ItemID);
        List<ShoppingCart> PlaceOrder (int p_ID, float p_Price, int p_Quantity, int p_StoreID, int p_CustomerID);
        List<Order> CustomerOrder(int p_CustomerID);
        List<Order> StoreOrder(int p_StoreID);

    }
}