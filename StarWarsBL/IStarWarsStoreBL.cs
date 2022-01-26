using StarWarsModel;

namespace StarWarsBL{
    public interface IStarWarsStoreBL{
        Customer AddCustomer(Customer n_customer);
        List<Customer> SearchCustomer(string n_customer);
    }
}