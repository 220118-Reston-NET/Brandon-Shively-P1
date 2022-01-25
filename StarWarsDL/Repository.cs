using System.Text.Json;
using StarWarsModel;

namespace StarWarsDL{
    public class Repository : IRepository{
        private string _filepath = "../StarWarsDL/Database/";
        private string _jsonString;
        public Customer AddCustomer(Customer n_customer)
        {
            string path = _filepath + "Customer.json";
            _jsonString = JsonSerializer.Serialize(n_customer, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(path , _jsonString);
            return n_customer;
        }
    }
}