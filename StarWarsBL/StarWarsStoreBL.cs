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
    }
}
