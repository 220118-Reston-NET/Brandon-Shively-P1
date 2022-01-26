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

        public List<Customer> SearchCustomer(string n_customer){
            List<Customer> listOfCustomers = _repo.GetAllCustomers();
            return listOfCustomers
                .Where(customer => customer.Name.Contains(n_customer))
                .ToList();
        }
    }
}
